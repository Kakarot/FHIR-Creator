using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FHIR_Creator
{
    public class ReadFhir
    {
        string crud, url;
        int patientID;
              

       public ReadFhir(string crud, string url, int patientID)
        {
            this.crud = crud;
            this.url = url;
            this.patientID = patientID;
        }

        public string PerformAction()
        {
            var result = "";
            if (crud == "Read")
            {
                var allergyIntolerance = new AllergyIntolerance(url.Trim());
               // var allergyIntolerance = new AllergyIntolerance("http://fhirtest.uhn.ca/baseDstu2/");
                //var patientID = 6140; //Patient ID for FHIR Server
                
                var medications = new List<string>() { "hydrocodone", "aspirin" }; //medications the patient is taking
                var response = allergyIntolerance.GetListOfMedicationAllergies(patientID, medications).ToList();
                foreach(string r in response)
                {
                    result += r;
                }             
            }
            return result;
        }
    }
}
