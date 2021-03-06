﻿namespace FHIR_Creator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCRUD = new System.Windows.Forms.ComboBox();
            this.textboxFhirServer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAllergyIntoleranceID = new System.Windows.Forms.Label();
            this.textBoxAllergyIntoleranceID = new System.Windows.Forms.TextBox();
            this.buttonPatient = new System.Windows.Forms.Button();
            this.labelBindPatientID = new System.Windows.Forms.Label();
            this.textBoxBindPatientID = new System.Windows.Forms.TextBox();
            this.buttonMedicationOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FHIR Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CRUD";
            // 
            // comboCRUD
            // 
            this.comboCRUD.FormattingEnabled = true;
            this.comboCRUD.Items.AddRange(new object[] {
            "POST",
            "GET",
            "SEARCH"});
            this.comboCRUD.Location = new System.Drawing.Point(98, 97);
            this.comboCRUD.Name = "comboCRUD";
            this.comboCRUD.Size = new System.Drawing.Size(73, 21);
            this.comboCRUD.TabIndex = 2;
            this.comboCRUD.Text = "GET";
            this.comboCRUD.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textboxFhirServer
            // 
            this.textboxFhirServer.Location = new System.Drawing.Point(59, 34);
            this.textboxFhirServer.Name = "textboxFhirServer";
            this.textboxFhirServer.Size = new System.Drawing.Size(176, 20);
            this.textboxFhirServer.TabIndex = 3;
            this.textboxFhirServer.Text = "http://fhirtest.uhn.ca/baseDstu2/\r\n";
            this.textboxFhirServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Perform Action";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAllergyIntoleranceID
            // 
            this.labelAllergyIntoleranceID.AutoSize = true;
            this.labelAllergyIntoleranceID.Location = new System.Drawing.Point(82, 137);
            this.labelAllergyIntoleranceID.Name = "labelAllergyIntoleranceID";
            this.labelAllergyIntoleranceID.Size = new System.Drawing.Size(108, 13);
            this.labelAllergyIntoleranceID.TabIndex = 7;
            this.labelAllergyIntoleranceID.Text = "Allergy Intolerance ID";
            // 
            // textBoxAllergyIntoleranceID
            // 
            this.textBoxAllergyIntoleranceID.Location = new System.Drawing.Point(85, 153);
            this.textBoxAllergyIntoleranceID.Name = "textBoxAllergyIntoleranceID";
            this.textBoxAllergyIntoleranceID.Size = new System.Drawing.Size(100, 20);
            this.textBoxAllergyIntoleranceID.TabIndex = 8;
            this.textBoxAllergyIntoleranceID.Text = "6140";
            this.textBoxAllergyIntoleranceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPatient
            // 
            this.buttonPatient.Location = new System.Drawing.Point(12, 5);
            this.buttonPatient.Name = "buttonPatient";
            this.buttonPatient.Size = new System.Drawing.Size(75, 23);
            this.buttonPatient.TabIndex = 11;
            this.buttonPatient.Text = "Patient";
            this.buttonPatient.UseVisualStyleBackColor = true;
            this.buttonPatient.Click += new System.EventHandler(this.buttonPatient_Click);
            // 
            // labelBindPatientID
            // 
            this.labelBindPatientID.AutoSize = true;
            this.labelBindPatientID.Location = new System.Drawing.Point(86, 203);
            this.labelBindPatientID.Name = "labelBindPatientID";
            this.labelBindPatientID.Size = new System.Drawing.Size(104, 13);
            this.labelBindPatientID.TabIndex = 12;
            this.labelBindPatientID.Text = "Patient ID to bind to:";
            this.labelBindPatientID.Visible = false;
            // 
            // textBoxBindPatientID
            // 
            this.textBoxBindPatientID.Location = new System.Drawing.Point(89, 220);
            this.textBoxBindPatientID.Name = "textBoxBindPatientID";
            this.textBoxBindPatientID.Size = new System.Drawing.Size(100, 20);
            this.textBoxBindPatientID.TabIndex = 13;
            this.textBoxBindPatientID.Text = "21613";
            this.textBoxBindPatientID.Visible = false;
            // 
            // buttonMedicationOrder
            // 
            this.buttonMedicationOrder.Location = new System.Drawing.Point(188, 5);
            this.buttonMedicationOrder.Name = "buttonMedicationOrder";
            this.buttonMedicationOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonMedicationOrder.TabIndex = 14;
            this.buttonMedicationOrder.Text = "Medication Order";
            this.buttonMedicationOrder.UseVisualStyleBackColor = true;
            this.buttonMedicationOrder.Click += new System.EventHandler(this.buttonMedicationOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 316);
            this.Controls.Add(this.buttonMedicationOrder);
            this.Controls.Add(this.textBoxBindPatientID);
            this.Controls.Add(this.labelBindPatientID);
            this.Controls.Add(this.buttonPatient);
            this.Controls.Add(this.textBoxAllergyIntoleranceID);
            this.Controls.Add(this.labelAllergyIntoleranceID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textboxFhirServer);
            this.Controls.Add(this.comboCRUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Allergy Intolerance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCRUD;
        private System.Windows.Forms.TextBox textboxFhirServer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelAllergyIntoleranceID;
        private System.Windows.Forms.TextBox textBoxAllergyIntoleranceID;
        private System.Windows.Forms.Button buttonPatient;
        private System.Windows.Forms.Label labelBindPatientID;
        private System.Windows.Forms.TextBox textBoxBindPatientID;
        private System.Windows.Forms.Button buttonMedicationOrder;
    }
}

