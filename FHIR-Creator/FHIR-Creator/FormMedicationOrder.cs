﻿using System;
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
    public partial class FormMedicationOrder : Form
    {
        public FormMedicationOrder()
        {
            InitializeComponent();
        }

        private void comboBoxCRUD_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxCRUD.Text)
            {
                case "POST":
                    labelMedicationOrderID.Text = "Medication Name";                   
                    textBoxMedicationOrderID.Text = "hydrocodone";
                    labelBindPatientID.Visible = true;
                    textBoxBindPatientID.Visible = true;
                    textBoxBindPatientID.Text = "21613";
                    break;
                case "GET":
                    labelMedicationOrderID.Text = "Medication Order ID";
                    labelBindPatientID.Visible = false;
                    textBoxBindPatientID.Visible = false;
                    break;
                case "SEARCH":
                    labelMedicationOrderID.Text = "Patient ID";
                    labelBindPatientID.Visible = false;
                    textBoxBindPatientID.Visible = false;
                    textBoxBindPatientID.Text = "21613";
                    break;
            }
        }

        private void buttonPerformAction_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxCRUD.Text)
                {
                    case "GET":
                        MedicationOrderFhir medicationOrderFhirGet = new MedicationOrderFhir(textBoxFhirServer.Text, null);
                        MessageBox.Show(medicationOrderFhirGet.PerformActionGET(textBoxMedicationOrderID.Text));
                        break;
                    case "POST":
                        MedicationOrderFhir medicationOrderFhirPost = new MedicationOrderFhir(textBoxFhirServer.Text, null);
                        MessageBox.Show(medicationOrderFhirPost.PerformActionPOST(textBoxBindPatientID.Text, textBoxMedicationOrderID.Text));
                        break;
                    case "SEARCH":
                        MedicationOrderFhir medicationOrderFhirSearch = new MedicationOrderFhir(textBoxFhirServer.Text, null);
                        MessageBox.Show(medicationOrderFhirSearch.PerformActionSEARCH(textBoxMedicationOrderID.Text));
                        break;
                }
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show("Sorry something went horribly wrong. Here is the error: " + ex.Message);
            }
        }
    }
}
