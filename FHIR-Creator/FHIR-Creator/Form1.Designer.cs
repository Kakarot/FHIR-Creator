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
            this.comboCreate = new System.Windows.Forms.ComboBox();
            this.fhirServer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FHIR Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboCreate
            // 
            this.comboCreate.FormattingEnabled = true;
            this.comboCreate.Items.AddRange(new object[] {
            "Patient",
            "Allergy Intolerance"});
            this.comboCreate.Location = new System.Drawing.Point(71, 128);
            this.comboCreate.Name = "comboCreate";
            this.comboCreate.Size = new System.Drawing.Size(121, 21);
            this.comboCreate.TabIndex = 2;
            this.comboCreate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fhirServer
            // 
            this.fhirServer.Location = new System.Drawing.Point(53, 65);
            this.fhirServer.Name = "fhirServer";
            this.fhirServer.Size = new System.Drawing.Size(176, 20);
            this.fhirServer.TabIndex = 3;
            this.fhirServer.Text = "http://fhirtest.uhn.ca/baseDstu2/\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Perform Action";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fhirServer);
            this.Controls.Add(this.comboCreate);
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
        private System.Windows.Forms.ComboBox comboCreate;
        private System.Windows.Forms.TextBox fhirServer;
        private System.Windows.Forms.Button button1;
    }
}

