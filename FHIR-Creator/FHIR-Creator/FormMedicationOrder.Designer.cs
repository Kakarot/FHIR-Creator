namespace FHIR_Creator
{
    partial class FormMedicationOrder
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
            this.buttonPerformAction = new System.Windows.Forms.Button();
            this.textBoxMedicationOrderID = new System.Windows.Forms.TextBox();
            this.labelMedicationOrderID = new System.Windows.Forms.Label();
            this.labelCRUD = new System.Windows.Forms.Label();
            this.comboBoxCRUD = new System.Windows.Forms.ComboBox();
            this.labelFhirServer = new System.Windows.Forms.Label();
            this.textBoxFhirServer = new System.Windows.Forms.TextBox();
            this.labelBindPatientID = new System.Windows.Forms.Label();
            this.textBoxBindPatientID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPerformAction
            // 
            this.buttonPerformAction.Location = new System.Drawing.Point(87, 266);
            this.buttonPerformAction.Name = "buttonPerformAction";
            this.buttonPerformAction.Size = new System.Drawing.Size(96, 23);
            this.buttonPerformAction.TabIndex = 13;
            this.buttonPerformAction.Text = "Perform Action";
            this.buttonPerformAction.UseVisualStyleBackColor = true;
            this.buttonPerformAction.Click += new System.EventHandler(this.buttonPerformAction_Click);
            // 
            // textBoxMedicationOrderID
            // 
            this.textBoxMedicationOrderID.Location = new System.Drawing.Point(87, 164);
            this.textBoxMedicationOrderID.Name = "textBoxMedicationOrderID";
            this.textBoxMedicationOrderID.Size = new System.Drawing.Size(100, 20);
            this.textBoxMedicationOrderID.TabIndex = 12;
            this.textBoxMedicationOrderID.Text = "6116";
            this.textBoxMedicationOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMedicationOrderID
            // 
            this.labelMedicationOrderID.AutoSize = true;
            this.labelMedicationOrderID.Location = new System.Drawing.Point(85, 138);
            this.labelMedicationOrderID.Name = "labelMedicationOrderID";
            this.labelMedicationOrderID.Size = new System.Drawing.Size(102, 13);
            this.labelMedicationOrderID.TabIndex = 11;
            this.labelMedicationOrderID.Text = "Medication Order ID";
            // 
            // labelCRUD
            // 
            this.labelCRUD.AutoSize = true;
            this.labelCRUD.Location = new System.Drawing.Point(110, 85);
            this.labelCRUD.Name = "labelCRUD";
            this.labelCRUD.Size = new System.Drawing.Size(38, 13);
            this.labelCRUD.TabIndex = 10;
            this.labelCRUD.Text = "CRUD";
            // 
            // comboBoxCRUD
            // 
            this.comboBoxCRUD.FormattingEnabled = true;
            this.comboBoxCRUD.Items.AddRange(new object[] {
            "POST",
            "GET"});
            this.comboBoxCRUD.Location = new System.Drawing.Point(95, 101);
            this.comboBoxCRUD.Name = "comboBoxCRUD";
            this.comboBoxCRUD.Size = new System.Drawing.Size(72, 21);
            this.comboBoxCRUD.TabIndex = 9;
            this.comboBoxCRUD.Text = "GET";
            this.comboBoxCRUD.SelectedIndexChanged += new System.EventHandler(this.comboBoxCRUD_SelectedIndexChanged);
            // 
            // labelFhirServer
            // 
            this.labelFhirServer.AutoSize = true;
            this.labelFhirServer.Location = new System.Drawing.Point(110, 21);
            this.labelFhirServer.Name = "labelFhirServer";
            this.labelFhirServer.Size = new System.Drawing.Size(66, 13);
            this.labelFhirServer.TabIndex = 8;
            this.labelFhirServer.Text = "FHIR Server";
            // 
            // textBoxFhirServer
            // 
            this.textBoxFhirServer.Location = new System.Drawing.Point(58, 37);
            this.textBoxFhirServer.Name = "textBoxFhirServer";
            this.textBoxFhirServer.Size = new System.Drawing.Size(169, 20);
            this.textBoxFhirServer.TabIndex = 7;
            this.textBoxFhirServer.Text = "http://fhirtest.uhn.ca/baseDstu2/";
            // 
            // labelBindPatientID
            // 
            this.labelBindPatientID.AutoSize = true;
            this.labelBindPatientID.Location = new System.Drawing.Point(92, 212);
            this.labelBindPatientID.Name = "labelBindPatientID";
            this.labelBindPatientID.Size = new System.Drawing.Size(92, 13);
            this.labelBindPatientID.TabIndex = 14;
            this.labelBindPatientID.Text = "Patient ID to bind:";
            this.labelBindPatientID.Visible = false;
            // 
            // textBoxBindPatientID
            // 
            this.textBoxBindPatientID.Location = new System.Drawing.Point(87, 228);
            this.textBoxBindPatientID.Name = "textBoxBindPatientID";
            this.textBoxBindPatientID.Size = new System.Drawing.Size(100, 20);
            this.textBoxBindPatientID.TabIndex = 15;
            this.textBoxBindPatientID.Visible = false;
            // 
            // FormMedicationOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 326);
            this.Controls.Add(this.textBoxBindPatientID);
            this.Controls.Add(this.labelBindPatientID);
            this.Controls.Add(this.buttonPerformAction);
            this.Controls.Add(this.textBoxMedicationOrderID);
            this.Controls.Add(this.labelMedicationOrderID);
            this.Controls.Add(this.labelCRUD);
            this.Controls.Add(this.comboBoxCRUD);
            this.Controls.Add(this.labelFhirServer);
            this.Controls.Add(this.textBoxFhirServer);
            this.Name = "FormMedicationOrder";
            this.Text = "Medication Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPerformAction;
        private System.Windows.Forms.TextBox textBoxMedicationOrderID;
        private System.Windows.Forms.Label labelMedicationOrderID;
        private System.Windows.Forms.Label labelCRUD;
        private System.Windows.Forms.ComboBox comboBoxCRUD;
        private System.Windows.Forms.Label labelFhirServer;
        private System.Windows.Forms.TextBox textBoxFhirServer;
        private System.Windows.Forms.Label labelBindPatientID;
        private System.Windows.Forms.TextBox textBoxBindPatientID;
    }
}