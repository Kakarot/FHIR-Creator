namespace FHIR_Creator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCRUD = new System.Windows.Forms.ComboBox();
            this.textboxFhirServer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.labelPatientID = new System.Windows.Forms.Label();
            this.textBoxPatientID = new System.Windows.Forms.TextBox();
            this.labelAllergyIntoleranceCode = new System.Windows.Forms.Label();
            this.textBoxAllergyIntoleranceCode = new System.Windows.Forms.TextBox();
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
            this.label2.Location = new System.Drawing.Point(119, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CRUD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboCRUD
            // 
            this.comboCRUD.FormattingEnabled = true;
            this.comboCRUD.Items.AddRange(new object[] {
            "Create",
            "Read",
            "Update",
            "Delete"});
            this.comboCRUD.Location = new System.Drawing.Point(109, 97);
            this.comboCRUD.Name = "comboCRUD";
            this.comboCRUD.Size = new System.Drawing.Size(62, 21);
            this.comboCRUD.TabIndex = 2;
            this.comboCRUD.Text = "Read";
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
            this.button1.Location = new System.Drawing.Point(84, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Perform Action";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Patient",
            "Allergy Intolerance"});
            this.comboType.Location = new System.Drawing.Point(78, 163);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(121, 21);
            this.comboType.TabIndex = 6;
            this.comboType.Text = "Allergy Intolerance";
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // labelPatientID
            // 
            this.labelPatientID.AutoSize = true;
            this.labelPatientID.Location = new System.Drawing.Point(105, 212);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(54, 13);
            this.labelPatientID.TabIndex = 7;
            this.labelPatientID.Text = "Patient ID";
            // 
            // textBoxPatientID
            // 
            this.textBoxPatientID.Location = new System.Drawing.Point(84, 228);
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.Size = new System.Drawing.Size(100, 20);
            this.textBoxPatientID.TabIndex = 8;
            this.textBoxPatientID.Text = "6140";
            this.textBoxPatientID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAllergyIntoleranceCode
            // 
            this.labelAllergyIntoleranceCode.AutoSize = true;
            this.labelAllergyIntoleranceCode.Location = new System.Drawing.Point(75, 293);
            this.labelAllergyIntoleranceCode.Name = "labelAllergyIntoleranceCode";
            this.labelAllergyIntoleranceCode.Size = new System.Drawing.Size(122, 13);
            this.labelAllergyIntoleranceCode.TabIndex = 9;
            this.labelAllergyIntoleranceCode.Text = "Allergy Intolerance Code";
            this.labelAllergyIntoleranceCode.Visible = false;
            // 
            // textBoxAllergyIntoleranceCode
            // 
            this.textBoxAllergyIntoleranceCode.Location = new System.Drawing.Point(84, 321);
            this.textBoxAllergyIntoleranceCode.Name = "textBoxAllergyIntoleranceCode";
            this.textBoxAllergyIntoleranceCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxAllergyIntoleranceCode.TabIndex = 10;
            this.textBoxAllergyIntoleranceCode.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 452);
            this.Controls.Add(this.textBoxAllergyIntoleranceCode);
            this.Controls.Add(this.labelAllergyIntoleranceCode);
            this.Controls.Add(this.textBoxPatientID);
            this.Controls.Add(this.labelPatientID);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textboxFhirServer);
            this.Controls.Add(this.comboCRUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FHIR Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCRUD;
        private System.Windows.Forms.TextBox textboxFhirServer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label labelPatientID;
        private System.Windows.Forms.TextBox textBoxPatientID;
        private System.Windows.Forms.Label labelAllergyIntoleranceCode;
        private System.Windows.Forms.TextBox textBoxAllergyIntoleranceCode;
    }
}

