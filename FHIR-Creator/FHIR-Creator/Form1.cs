using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FHIR_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCRUD.Text == "POST")
            {
                labelAllergyIntoleranceID.Text = "Allergy Intolerance Code";
                textBoxAllergyIntoleranceID.Text = String.Empty;
                textBoxBindPatientID.Visible = true;
                labelBindPatientID.Visible = true;
            }
            else if(comboCRUD.Text == "SEARCH")
            {
                labelAllergyIntoleranceID.Text = "Patient ID to Search on:";
                textBoxAllergyIntoleranceID.Text = String.Empty;
                textBoxBindPatientID.Visible = false;
                labelBindPatientID.Visible = false;
            }
            else
            {
                labelAllergyIntoleranceID.Text = "Allery Intolerance ID";
                textBoxBindPatientID.Visible = false;
                labelBindPatientID.Visible = false;
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboCRUD.Text)
                {
                    case "POST":
                        AllergyIntoleranceFhir postFhir = new AllergyIntoleranceFhir(
comboCRUD.Text, textboxFhirServer.Text, 0);
                        MessageBox.Show(postFhir.PerformActionPOST(textBoxAllergyIntoleranceID.Text, textBoxBindPatientID.Text), "Resource ID");
                        break;
                    case "GET":
                        AllergyIntoleranceFhir readFhir = new AllergyIntoleranceFhir(
comboCRUD.Text, textboxFhirServer.Text, Int32.Parse(textBoxAllergyIntoleranceID.Text));
                        MessageBox.Show(readFhir.PerformActionGET(), "Allergy Intolerance Coding");
                        break;
                    case "SEARCH":
                        AllergyIntoleranceFhir searchFhir = new AllergyIntoleranceFhir(
comboCRUD.Text, textboxFhirServer.Text, Int32.Parse(textBoxAllergyIntoleranceID.Text));
                        MessageBox.Show(searchFhir.PerformActionSEARCH(textBoxAllergyIntoleranceID.Text), "Allergy Intolerance Resource ID");
                        break;
                }
            }//end try
            catch(Exception ex)
            {
                MessageBox.Show("Sorry something went horribly wrong. Here is the error: "+ex.Message);
            }
        }     

       

        private void buttonPatient_Click(object sender, EventArgs e)
        {
            FormPatient myFormPatient = new FormPatient();
            myFormPatient.ShowDialog();
        }

        private void buttonMedicationOrder_Click(object sender, EventArgs e)
        {
            FormMedicationOrder myFormMedicationOrder = new FormMedicationOrder();
            myFormMedicationOrder.ShowDialog();
        }
    }
}
