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

        //public string GetPatientName(string patientID)
        //{
        //    var patientResource = fhirClient.Read<Hl7.Fhir.Model.Patient>("Patient/" + patientID);
        //    string returnName=String.Empty;
            
        //    foreach(var p in patientResource.Name)
        //    {
        //        var nameCollection = p.Family.ToList();
        //        foreach(var nc in nameCollection)
        //        {
        //            returnName += nc;
        //        }
        //    }
        //    return returnName;
        //}

        public string PostMedicationOrder(string patientID, string medicationOrder)
        {
            //Create an empty medication order resource and then assign attributes
            Hl7.Fhir.Model.MedicationOrder fhirMedicationOrder = new Hl7.Fhir.Model.MedicationOrder();
            //Hl7.Fhir.Model.Element fhirElement = new Hl7.Fhir.Model.MedicationOrder();
            Hl7.Fhir.Model.Medication medication = new Hl7.Fhir.Model.Medication();
            
            Code code = new Code(medicationOrder);
            Coding codingList = new Coding();
            codingList.Code = medicationOrder;
            fhirMedicationOrder.Medication = codingList;
            //  medication.Code.Coding.Add(new Hl7.Fhir.Model.Coding("hydrocodone"));
            fhirMedicationOrder.Medication = codingList;
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
