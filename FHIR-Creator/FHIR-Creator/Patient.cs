using Hl7.Fhir.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHIR_Creator
{
    class Patient
    {
        private FhirClient fhirClient = null;


        public Patient(string fhirServer)
        {
            if (String.IsNullOrEmpty(fhirServer))
                throw new Exception("Invalid URL passed to Patient Constructor");

            fhirClient = new FhirClient(fhirServer);

        }

        public string GetPatientName(string patientID)
        {
            var patientResource = fhirClient.Read<Hl7.Fhir.Model.Patient>("Patient/" + patientID);
            string returnName=String.Empty;
            
            foreach(var p in patientResource.Name)
            {
                var nameCollection = p.Given.ToList();
                foreach(var nc in nameCollection)
                {
                    returnName += nc;
                }
            }
            return returnName;
        }

        public string PostPatient(string name)
        {
            //Create an empty patient resource and then assign attributes
            Hl7.Fhir.Model.Patient fhirPatient = new Hl7.Fhir.Model.Patient();
            fhirPatient.Name.Add(new Hl7.Fhir.Model.HumanName().AndFamily(name));

            //Push the local patient resource to the FHIR Server and expect a newly assigned ID
            var patientResource = fhirClient.Create<Hl7.Fhir.Model.Patient>(fhirPatient);

            String returnID = "The newly created Patient ID is: ";

            returnID += patientResource.Id;
            return returnID;
        }
    }
}
