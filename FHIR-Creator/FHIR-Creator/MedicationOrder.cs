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

            fhirMedicationOrder.Medication = new ResourceReference(){
                Reference = fhirClient.Endpoint.OriginalString +"Medication/"+ medicationResourceID,
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
    }
}
