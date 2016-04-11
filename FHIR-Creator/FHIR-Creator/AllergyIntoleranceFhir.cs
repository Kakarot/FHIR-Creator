using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FHIR_Creator
{
    public class AllergyIntoleranceFhir
    {
        string crud, url;
        int patientID;
              

       public AllergyIntoleranceFhir(string crud, string url, int patientID)
        {
            this.crud = crud;
            this.url = url;
            this.patientID = patientID;
        }

        public string PerformActionGET()
        {
            var result = "";           
                var allergyIntolerance = new AllergyIntolerance(url.Trim());
                // var allergyIntolerance = new AllergyIntolerance("http://fhirtest.uhn.ca/baseDstu2/");
                //var patientID = 6140; //Patient ID for FHIR Server

                // var medications = new List<string>() { "hydrocodone", "aspirin" }; //medications the patient is taking
                //var response = allergyIntolerance.GetListOfMedicationAllergies(patientID, medications).ToList();
                var response = allergyIntolerance.GetPatientsKnownAllergies(patientID);
                var medicationCodes = response.Keys;     
                foreach (string m in medicationCodes)
                {
                    result += m;
                }  
            
            return result;
        }

        public string PerformActionPOST(string allergyIntoleranceCode, string patientID)
        {
            var result = "";

            var allergyIntolerance = new AllergyIntolerance(url.Trim());
          
            result = allergyIntolerance.CreateAllergyIntolerance(patientID, allergyIntoleranceCode);

            return result;
        }

        public string PerformActionSEARCH(string patientID)
        {
            var result = "";
            var allergyIntolerance = new AllergyIntolerance(url.Trim());
            // var allergyIntolerance = new AllergyIntolerance("http://fhirtest.uhn.ca/baseDstu2/");
            //var patientID = 6140; //Patient ID for FHIR Server

            // var medications = new List<string>() { "hydrocodone", "aspirin" }; //medications the patient is taking
            //var response = allergyIntolerance.GetListOfMedicationAllergies(patientID, medications).ToList();
            var response = allergyIntolerance.SearchKnownAllergiesOnPatientID(patientID);
            //var medicationCodes = response.Keys;
            //foreach (string m in medicationCodes)
            //{
            //    result += m;
            //}
            result = response;
            return result;
        }
    }
}
