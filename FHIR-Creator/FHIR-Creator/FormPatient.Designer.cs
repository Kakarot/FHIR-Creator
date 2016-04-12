namespace FHIR_Creator
{
    partial class FormPatient
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
            this.textBoxFhirServer = new System.Windows.Forms.TextBox();
            this.labelFhirServer = new System.Windows.Forms.Label();
            this.comboBoxCRUD = new System.Windows.Forms.ComboBox();
            this.labelCRUD = new System.Windows.Forms.Label();
            this.labelPatientID = new System.Windows.Forms.Label();
            this.textBoxPatientID = new System.Windows.Forms.TextBox();
            this.buttonPerformAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFhirServer
            // 
            this.textBoxFhirServer.Location = new System.Drawing.Point(58, 47);
            this.textBoxFhirServer.Name = "textBoxFhirServer";
            this.textBoxFhirServer.Size = new System.Drawing.Size(169, 20);
            this.textBoxFhirServer.TabIndex = 0;
            this.textBoxFhirServer.Text = "http://fhirtest.uhn.ca/baseDstu2/";
            this.textBoxFhirServer.TextChanged += new System.EventHandler(this.textBoxFhirServer_TextChanged);
            // 
            // labelFhirServer
            // 
            this.labelFhirServer.AutoSize = true;
            this.labelFhirServer.Location = new System.Drawing.Point(110, 31);
            this.labelFhirServer.Name = "labelFhirServer";
            this.labelFhirServer.Size = new System.Drawing.Size(66, 13);
            this.labelFhirServer.TabIndex = 1;
            this.labelFhirServer.Text = "FHIR Server";
            this.labelFhirServer.Click += new System.EventHandler(this.labelFhirServer_Click);
            // 
            // comboBoxCRUD
            // 
            this.comboBoxCRUD.FormattingEnabled = true;
            this.comboBoxCRUD.Items.AddRange(new object[] {
            "POST",
            "GET"});
            this.comboBoxCRUD.Location = new System.Drawing.Point(95, 111);
            this.comboBoxCRUD.Name = "comboBoxCRUD";
            this.comboBoxCRUD.Size = new System.Drawing.Size(72, 21);
            this.comboBoxCRUD.TabIndex = 2;
            this.comboBoxCRUD.Text = "GET";
            this.comboBoxCRUD.SelectedIndexChanged += new System.EventHandler(this.comboBoxCRUD_SelectedIndexChanged);
            // 
            // labelCRUD
            // 
            this.labelCRUD.AutoSize = true;
            this.labelCRUD.Location = new System.Drawing.Point(110, 95);
            this.labelCRUD.Name = "labelCRUD";
            this.labelCRUD.Size = new System.Drawing.Size(38, 13);
            this.labelCRUD.TabIndex = 3;
            this.labelCRUD.Text = "CRUD";
            this.labelCRUD.Click += new System.EventHandler(this.labelCRUD_Click);
            // 
            // labelPatientID
            // 
            this.labelPatientID.AutoSize = true;
            this.labelPatientID.Location = new System.Drawing.Point(113, 149);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(54, 13);
            this.labelPatientID.TabIndex = 4;
            this.labelPatientID.Text = "Patient ID";
            this.labelPatientID.Click += new System.EventHandler(this.labelPatientID_Click);
            // 
            // textBoxPatientID
            // 
            this.textBoxPatientID.Location = new System.Drawing.Point(87, 174);
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.Size = new System.Drawing.Size(100, 20);
            this.textBoxPatientID.TabIndex = 5;
            this.textBoxPatientID.Text = "6116";
            this.textBoxPatientID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPatientID.TextChanged += new System.EventHandler(this.textBoxPatientID_TextChanged);
            // 
            // buttonPerformAction
            // 
            this.buttonPerformAction.Location = new System.Drawing.Point(87, 226);
            this.buttonPerformAction.Name = "buttonPerformAction";
            this.buttonPerformAction.Size = new System.Drawing.Size(96, 23);
            this.buttonPerformAction.TabIndex = 6;
            this.buttonPerformAction.Text = "Perform Action";
            this.buttonPerformAction.UseVisualStyleBackColor = true;
            this.buttonPerformAction.Click += new System.EventHandler(this.buttonPerformAction_Click);
            // 
            // FormPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonPerformAction);
            this.Controls.Add(this.textBoxPatientID);
            this.Controls.Add(this.labelPatientID);
            this.Controls.Add(this.labelCRUD);
            this.Controls.Add(this.comboBoxCRUD);
            this.Controls.Add(this.labelFhirServer);
            this.Controls.Add(this.textBoxFhirServer);
            this.Name = "FormPatient";
            this.Text = "Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFhirServer;
        private System.Windows.Forms.Label labelFhirServer;
        private System.Windows.Forms.ComboBox comboBoxCRUD;
        private System.Windows.Forms.Label labelCRUD;
        private System.Windows.Forms.Label labelPatientID;
        private System.Windows.Forms.TextBox textBoxPatientID;
        private System.Windows.Forms.Button buttonPerformAction;
    }
}