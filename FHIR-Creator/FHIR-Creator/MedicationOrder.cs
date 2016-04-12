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

        public string PostMedicationOrder(string patientID, string medicationOrder)
        {
            //Create an empty medication order resource and then assign attributes
            Hl7.Fhir.Model.MedicationOrder fhirMedicationOrder = new Hl7.Fhir.Model.MedicationOrder();
            //Hl7.Fhir.Model.Element fhirElement = new Hl7.Fhir.Model.MedicationOrder();
            Hl7.Fhir.Model.Medication medication = new Hl7.Fhir.Model.Medication();
            
            Code code = new Code(medicationOrder);
            Coding codingList = new Coding();
            codingList.Code = medicationOrder;
            fhirMedicationOrder.Medication = new CodeableConcept("ICD-10", "hydrocodone");
            
            
           // fhirMedicationOrder.Medication = codingList;
            //  medication.Code.Coding.Add(new Hl7.Fhir.Model.Coding("hydrocodone"));
          //  fhirMedicationOrder.Medication = codingList;
            //.Name.Add(new Hl7.Fhir.Model.HumanName().AndFamily(name));

            //Now associate Medication Order to a Patient
            fhirMedicationOrder.Patient = new Hl7.Fhir.Model.ResourceReference();
            fhirMedicationOrder.Patient.Reference = "Patient/" + patientID;

            //Push the local patient resource to the FHIR Server and expect a newly assigned ID
            var medicationOrderResource = fhirClient.Create<Hl7.Fhir.Model.MedicationOrder>(fhirMedicationOrder);

            String returnID = "The newly created Medication ID is: ";

            returnID += medicationOrderResource.Id;
            return returnID;
        }
    }
}
