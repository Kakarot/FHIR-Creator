﻿using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using System.Net;

public class AllergyIntolerance
    {       
        private FhirClient fhirClient = null;


        public AllergyIntolerance(string fhirServer)
        {
            if (String.IsNullOrEmpty(fhirServer))
                throw new Exception("Invalid URL passed to AllergyIntolerance Constructor");

            fhirClient = new FhirClient(fhirServer);
           
        }

        //The controller is expected to receive two pieces of data from an EHR.
        //The List of medications they currently know their patient is taking
        //The patient's ID from FHIR
        /// <summary>
        /// The controller is expected to receive two data structures from an EHR.
        /// </summary>       
        /// <param name="patientID"> The patient's ID from FHIR</param>
        /// <param name="medications"> The List of medications they currently know their patient is taking</param>
        public IEnumerable<string> GetListOfMedicationAllergies(int patientID, IList<string> medications)
        {
            //ToDo: Discuss with team about returning a dictionary or wrapper class, so that we can inform the EHR
            //      on both the medication conflict and the allergy code.


            //First let us fetch the known allergies of the patient.
            var returnedAllergies = new List<string>();
            var lookupPatientsKnownAllergies = GetPatientsKnownAllergies(patientID);
            if (lookupPatientsKnownAllergies == null)
            {
                //There are no records on the FHIR server of this patient having any allergies.
                return returnedAllergies;
            }         

            ////Now we retrieve the list of known allergies their medications can trigger
            var listOfAllergicMedications = DetermineListOfAllergicMedications(medications, lookupPatientsKnownAllergies);
            return listOfAllergicMedications;  
        }//end GetListOfMedicationAllergies method


        //Returns an IEnumerable of medications the patient is allergic to
        /// <summary>
        /// Private helper method.
        /// </summary>       
        /// <param name="medications"> List of patients medications</param>
        /// <param name="lookupPatientsKnownAllergies"> Dictionary of allergies the patient has, populated from FHIR</param>
        private IEnumerable<string> DetermineListOfAllergicMedications(IList<string> medications, IDictionary<string, bool> lookupPatientsKnownAllergies)
        {
            return
                medications
                .Where(a => Constants.ALLERGY_LOOKUP.ContainsKey(a))
                .Select(a => new Tuple<string, List<string>>(a, Constants.ALLERGY_LOOKUP[a]))
                .Where(a => a.Item2.Any(c => lookupPatientsKnownAllergies.ContainsKey(c)))
                .Select(a => a.Item1);
        }

        /// If you only care if a patient is allergic to one of their medications, call this method.
        /// <summary>
        /// This method can take use the data given to it from the EHR, as is, and determine if there is a problem.
        /// However, the downside is this method only returns a Boolean. If you want a list of the medications
        /// the patient is allergic to, then call GetListOfMedicationAllergies() instead.
        /// </summary>       
        /// <param name="patientID"> The patient's ID from FHIR</param>
        /// <param name="medications"> The List of medications they currently know their patient is taking</param>
        public Boolean IsAllergicToMedications(int patientID, IList<String> medications)
        {
            //First let us fetch the known allergies of the patient.
            var returnedAllergies = new List<string>();
            var lookupPatientsKnownAllergies = GetPatientsKnownAllergies(patientID);
            if (lookupPatientsKnownAllergies == null)
            {
                //There are no records on the FHIR server of this patient having any allergies.
                return false;
            }
            return IsAllergic(medications, lookupPatientsKnownAllergies);

        }//end IsAllergicToMedications method



        /// Private helper method for comparing the patient's medications against their known allergies
        /// <summary>       
        /// I'm the least happy with this method, because I know I can refactor this to do more to also give me a list or dictionary of my results.
        /// </summary>       
        /// <param name="medications"> List of patients medications</param>
        /// <param name="lookupPatientsKnownAllergies"> Dictonary of patient's known allergies</param>
        private Boolean IsAllergic(IList<string> medications, IDictionary<string, Boolean> lookupPatientsKnownAllergies)
        {
            var currentAllergyCodeList = new List<string>();
            
            return medications
                 .Where(a=>!string.IsNullOrEmpty(a))
                 .Select(a=>a.ToLower())
                 .Where(a => Constants.ALLERGY_LOOKUP.ContainsKey(a))
                 .Select(a => new Tuple<string, List<string>>(a, Constants.ALLERGY_LOOKUP[a]))
                 .Any(a => a.Item2.Any(c => lookupPatientsKnownAllergies.ContainsKey(c)));
        }//end IsAllergic method

         
        /// <summary>       
        /// Returns a dictionary of patient's allergies (ICD-10-CM Diagnosis Codes) from the FHIR server
        /// </summary>       
        /// <param name="patientID"> Unique ID of patient for FHIR server</param>
        public IDictionary<string, Boolean> GetPatientsKnownAllergies(int patientID)
        {
            //Create a dictionary for O(1) lookup time later.
            var lookupPatientsKnownAllergies = new Dictionary<string, Boolean>();
        ////  Bundle results = fhirClient.WholeSystemSearch(new string[] { @"reference=patient/6116" });
        //WebRequest webRequest = WebRequest.Create(fhirClient.);
        //WebResponse webResp = webRequest.GetResponse();
        //Search Bundle here


        //Attempt to retrieve Allergy Intolerance codes of a patient from the remote FHIR server
    //    var patientResource = fhirClient.Read<Hl7.Fhir.Model.Patient>("Patient/" + patientID);
       // var allergyResource = patientResource..ResourceType<Hl7.Fhir.Model.AllergyIntolerance>;
        var allergyResource = fhirClient.Read<Hl7.Fhir.Model.AllergyIntolerance>("AllergyIntolerance/" + patientID);
      //  var allergyResource = fhirClient.Read<Hl7.Fhir.Model.AllergyIntolerance>("AllergyIntolerance/" + patientID); 
        return allergyResource.Substance.Coding.Count == 0 ? lookupPatientsKnownAllergies :
                allergyResource.Substance.Coding.ToDictionary(a => a.Code, a => true);
        }//end GetPatientsKnownAllergies

    public string CreateAllergyIntolerance(string patientID, string allergyIntoleranceCode)
    {
       
        //Create an empty Allergy Intolerance resource and then assign attributes
        Hl7.Fhir.Model.AllergyIntolerance fhirAllergyIntolerance = new Hl7.Fhir.Model.AllergyIntolerance();        
        Coding codingList = new Coding();
        codingList.Code = allergyIntoleranceCode;
        fhirAllergyIntolerance.Substance = new CodeableConcept();
        fhirAllergyIntolerance.Substance.Coding.Add(codingList);

       // Hl7.Fhir.Model.Patient fhirPatient = fhirClient.Read<Hl7.Fhir.Model.Patient>("Patient/21613");
        fhirAllergyIntolerance.Patient = new ResourceReference();
        fhirAllergyIntolerance.Patient.Reference = "Patient/"+patientID;

        //Push the local patient resource to the FHIR Server and expect a newly assigned ID
        var allergyResource = fhirClient.Create<Hl7.Fhir.Model.AllergyIntolerance>(fhirAllergyIntolerance);

        String returnID = "The newly created Allergy Intolerance ID is: ";

        returnID += allergyResource.Id;
        return returnID;        

    }//end CreateAllergyIntolerance method

    public string SearchKnownAllergiesOnPatientID(string patientID)
    {
        //First we need to set up the Search Param Object
        SearchParams mySearch = new SearchParams();

        //Create a tuple containing search parameters for SearchParam object
        // equivalent of "AllergyIntolerance?patient=6116";
        Tuple<string, string> mySearchTuple = new Tuple<string, string>("patient", patientID);
        mySearch.Parameters.Add(mySearchTuple);
      
        //Query the fhir server with search parameters, we will retrieve a bundle
        var searchResultResponse = fhirClient.Search<Hl7.Fhir.Model.AllergyIntolerance>(mySearch);
       
        //There is an array of "entries" that can return. Get a list of all the entries.
        var listOfentries = searchResultResponse.Entry;

        if (listOfentries.Count == 0)
            return "No Allergy Intolerance entries found on the FHIR server for: "+patientID;

        string medicationOrderIDs = String.Empty;
        foreach(var entry in listOfentries)
        {
            medicationOrderIDs += entry.Resource.Id+"\n";
        }


        //At this point we have a list of MedicationOrder IDs
        //Now for each medicationorder, we need the medication associated with it.
        //Note: MedicationOrder and Medication have a 1:1 mapping.



        return "bad";
     
    }//end SearchKnownAllergiesOnPatientID
}
