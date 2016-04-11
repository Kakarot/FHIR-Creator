using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FHIR_Creator
{
    public class PatientFhir
    {
        string url, patientID;
              

       public PatientFhir(string url, string patientID)
        {
            this.url = url;
            this.patientID = patientID;
        }

        public string PerformActionGET()
        {
            var result = "";
           
                var patient = new Patient(url.Trim());
                // var allergyIntolerance = new AllergyIntolerance("http://fhirtest.uhn.ca/baseDstu2/");
                //var patientID = 6140; //Patient ID for FHIR Server

                // var medications = new List<string>() { "hydrocodone", "aspirin" }; //medications the patient is taking
                //var response = allergyIntolerance.GetListOfMedicationAllergies(patientID, medications).ToList();
                result = patient.GetPatientName(patientID);
                 
            
            return result;
        }
        public string PerformActionPOST(string name)
        {
            var result = "";

            var patient = new Patient(url.Trim());
            // var allergyIntolerance = new AllergyIntolerance("http://fhirtest.uhn.ca/baseDstu2/");
            //var patientID = 6140; //Patient ID for FHIR Server

            // var medications = new List<string>() { "hydrocodone", "aspirin" }; //medications the patient is taking
            //var response = allergyIntolerance.GetListOfMedicationAllergies(patientID, medications).ToList();
            result = patient.PostPatient(name);


            return result;
        }
    }
}
