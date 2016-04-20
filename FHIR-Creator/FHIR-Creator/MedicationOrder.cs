using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHIR_Creator
{
    class MedicationOrder
    {
        private FhirClient fhirClient = null;


        public MedicationOrder(string fhirServer)
        {
            if (String.IsNullOrEmpty(fhirServer))
                throw new Exception("Invalid URL passed to Patient Constructor");

            fhirClient = new FhirClient(fhirServer);

        }

        public string GetMedicationOrder(string medicationOrderID)
        {
            var medicationOrderResource = fhirClient.Read<Hl7.Fhir.Model.MedicationOrder>("MedicationOrder/" + medicationOrderID);
            string returnName = String.Empty;
            // medicationOrderResource.Medication = new CodeableConcept();
            //var test = medicationOrderResource.Medication.GetExtensionValue<Coding>("medicationCodeableConcept");


            //The difficulty here is that this is considered a custom element and there is no model for it.
            //So just return the patient the resource is bound to
            return medicationOrderResource.Patient.Reference;

        }

        public string PostMedicationOrder(string patientID, string medicationName)
        {
            //Potential Parameters to pass in:
            //patientID, medicationName, system, and display

            //First we need to create our medication
            Medication medication = new Medication();
            medication.Code = new CodeableConcept("ICD-10", medicationName);

            //Now we need to push this to the server and grab the ID
            var medicationResource = fhirClient.Create<Hl7.Fhir.Model.Medication>(medication);
            string medicationResourceID = medicationResource.Id;

            //Create an empty medication order resource and then assign attributes
            Hl7.Fhir.Model.MedicationOrder fhirMedicationOrder = new Hl7.Fhir.Model.MedicationOrder();

            //There is no API for "Reference" in MedicationOrder model, unlike Patient model.
            //You must initialize ResourceReference inline.
            fhirMedicationOrder.Medication = new ResourceReference()
            {
                Reference = fhirClient.Endpoint.OriginalString + "Medication/" + medicationResourceID,
                Display = "EhrgoHealth"
            };

            //Now associate Medication Order to a Patient
            fhirMedicationOrder.Patient = new ResourceReference();
            fhirMedicationOrder.Patient.Reference = "Patient/" + patientID;

            //Push the local patient resource to the FHIR Server and expect a newly assigned ID
            var medicationOrderResource = fhirClient.Create<Hl7.Fhir.Model.MedicationOrder>(fhirMedicationOrder);

            //   medicationOrderResource.Medication
            String returnID = "The newly created Medication ID is: ";

            returnID += medicationOrderResource.Id;
            return returnID;
        }

        public string SearchPatientsMedication(string patientID)
        {
            IList<string> listOfMedications = new List<string>();

            //First we need to set up the Search Param Object
            SearchParams mySearch = new SearchParams();

            //Create a tuple containing search parameters for SearchParam object
            // equivalent of "MedicationOrder?patient=6116";
            Tuple<string, string> mySearchTuple = new Tuple<string, string>("patient", patientID);
            mySearch.Parameters.Add(mySearchTuple);

            //Query the fhir server with search parameters, we will retrieve a bundle
            var searchResultResponse = fhirClient.Search<Hl7.Fhir.Model.MedicationOrder>(mySearch);

            //There is an array of "entries" that can return. Get a list of all the entries.
            var listOfentries = searchResultResponse.Entry;

            if (listOfentries.Count == 0)
                return "No Medication Order entries found on the FHIR server for PatientID: " + patientID;



            //Initializing in for loop is not the greatest.
            foreach (var entry in listOfentries)
            {

                //The entries we have, do not contain the medication reference.

                var medicationOrderResource = fhirClient.Read<Hl7.Fhir.Model.MedicationOrder>("MedicationOrder/" + entry.Resource.Id);

                //Casted this because ((ResourceReference)medicationOrderResource.Medication).Reference
                //is not pretty as a parameter
                ResourceReference castedResourceReference = (ResourceReference)medicationOrderResource.Medication;

                var medicationResource = fhirClient.Read<Hl7.Fhir.Model.Medication>(castedResourceReference.Reference);

                CodeableConcept castedCodeableConcept = medicationResource.Code;
                List<Coding> listOfCodes = castedCodeableConcept.Coding;


                foreach (var c in listOfCodes)
                {
                    listOfMedications.Add(c.Code);
                }


            }
            string returnResult = String.Empty;
            foreach (var m in listOfMedications)
            {
                returnResult += m + "\n"; //Stringbuilder class would be better
            }

            return returnResult;
        }
    }
}
