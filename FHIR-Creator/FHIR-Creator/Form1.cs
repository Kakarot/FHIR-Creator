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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCRUD.Text == "Create" && comboType.Text == "Allergy Intolerance")
            {
                textBoxAllergyIntoleranceCode.Visible=true;
                labelAllergyIntoleranceCode.Visible=true;
            }
            else
            {
                textBoxAllergyIntoleranceCode.Visible = false;
                labelAllergyIntoleranceCode.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboType.Text)
                {
                    case "Patient": break;
                    case "Allergy Intolerance":
                        ReadFhir readFhir = new ReadFhir(
comboCRUD.Text, textboxFhirServer.Text, Int32.Parse(textBoxPatientID.Text));
                        MessageBox.Show(readFhir.PerformAction());
                        break;
                }
            }//end try
            catch(Exception ex)
            {
                MessageBox.Show("Sorry something went horribly wrong. Here is the error: "+ex.Message);
            }
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCRUD.Text == "Create" && comboType.Text == "Allergy Intolerance")
            {
                textBoxAllergyIntoleranceCode.Visible = true;
                labelAllergyIntoleranceCode.Visible = true;
            }
            else
            {
                textBoxAllergyIntoleranceCode.Visible = false;
                labelAllergyIntoleranceCode.Visible = false;
            }
        }

        private void labelPatientID_Click(object sender, EventArgs e)
        {

        }

        private void buttonPatient_Click(object sender, EventArgs e)
        {
            FormPatient myFormPatient = new FormPatient();
            myFormPatient.ShowDialog();
        }
    }
}
