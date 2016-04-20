using Hl7.Fhir.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHIR_Creator
{
    class MedicationOrderFhir
    {
        string url, patientID;


        public MedicationOrderFhir(string url, string patientID)
        {
            this.url = url;
            this.patientID = patientID;
        }

        public string PerformActionGET(string medicationOrderID)
        {
            var result = "";

            var medicationOrder = new MedicationOrder(url.Trim());
            // var allergyIntolerance = new AllergyIntolerance("http://fhirtest.uhn.ca/baseDstu2/");
            //var patientID = 6140; //Patient ID for FHIR Server

            // var medications = new List<string>() { "hydrocodone", "aspirin" }; //medications the patient is taking
            //var response = allergyIntolerance.GetListOfMedicationAllergies(patientID, medications).ToList();
            result = medicationOrder.GetMedicationOrder(medicationOrderID);


            return result;
        }

        public string PerformActionPOST(string patientID, string medicationOrderName)
        {
            var result = "";

            var medicationOrder = new MedicationOrder(url.Trim());
            // var allergyIntolerance = new AllergyIntolerance("http://fhirtest.uhn.ca/baseDstu2/");
            //var patientID = 6140; //Patient ID for FHIR Server

            // var medications = new List<string>() { "hydrocodone", "aspirin" }; //medications the patient is taking
            //var response = allergyIntolerance.GetListOfMedicationAllergies(patientID, medications).ToList();
            result = medicationOrder.PostMedicationOrder(patientID, medicationOrderName);


            return result;
        }

        public string PerformActionSEARCH(string patientID)
        {
            var result = "";
            var medicationOrder = new MedicationOrder(url.Trim());
            // var allergyIntolerance = new AllergyIntolerance("http://fhirtest.uhn.ca/baseDstu2/");
            //var patientID = 6140; //Patient ID for FHIR Server

            // var medications = new List<string>() { "hydrocodone", "aspirin" }; //medications the patient is taking
            //var response = allergyIntolerance.GetListOfMedicationAllergies(patientID, medications).ToList();
            var response = medicationOrder.SearchPatientsMedication(patientID);
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
