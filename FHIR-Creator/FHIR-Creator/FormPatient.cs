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
    public partial class FormPatient : Form
    {
        public FormPatient()
        {
            InitializeComponent();
        }

        private void buttonPerformAction_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxCRUD.Text)
                {
                    case "GET": 
                        PatientFhir patientFhirGet = new PatientFhir(textBoxFhirServer.Text, textBoxPatientID.Text);
                        MessageBox.Show(patientFhirGet.PerformActionGET());
                        break;
                    case "POST":
                        PatientFhir patientFhirPost = new PatientFhir(textBoxFhirServer.Text, textBoxPatientID.Text);
                        MessageBox.Show(patientFhirPost.PerformActionPOST(textBoxPatientID.Text));
                        break;
                }
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show("Sorry something went horribly wrong. Here is the error: " + ex.Message);
            }
        }

        private void comboBoxCRUD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCRUD.Text == "POST")
            {
                labelPatientID.Text = "Patient's Family Name";
            }
            else
            {
                labelPatientID.Text = "Patient ID";
            }
        }
    }
}
