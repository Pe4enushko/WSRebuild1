
namespace WSkillsRebuild1.Forms
{
    partial class AcceptBioForm
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
            this.Cmb_Services = new System.Windows.Forms.ComboBox();
            this.Btn_MoveService = new System.Windows.Forms.Button();
            this.Btn_RemoveService = new System.Windows.Forms.Button();
            this.Txt_Code = new System.Windows.Forms.TextBox();
            this.Lb_Code = new System.Windows.Forms.Label();
            this.Btn_GenerateCode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_Patients = new System.Windows.Forms.ComboBox();
            this.Btn_NewPatient = new System.Windows.Forms.Button();
            this.List_Services = new System.Windows.Forms.ListBox();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cmb_Services
            // 
            this.Cmb_Services.FormattingEnabled = true;
            this.Cmb_Services.Location = new System.Drawing.Point(304, 27);
            this.Cmb_Services.Name = "Cmb_Services";
            this.Cmb_Services.Size = new System.Drawing.Size(163, 21);
            this.Cmb_Services.TabIndex = 1;
            // 
            // Btn_MoveService
            // 
            this.Btn_MoveService.Location = new System.Drawing.Point(223, 27);
            this.Btn_MoveService.Name = "Btn_MoveService";
            this.Btn_MoveService.Size = new System.Drawing.Size(75, 23);
            this.Btn_MoveService.TabIndex = 2;
            this.Btn_MoveService.Text = "Move";
            this.Btn_MoveService.UseVisualStyleBackColor = true;
            this.Btn_MoveService.Click += new System.EventHandler(this.Btn_MoveService_Click);
            // 
            // Btn_RemoveService
            // 
            this.Btn_RemoveService.Location = new System.Drawing.Point(223, 57);
            this.Btn_RemoveService.Name = "Btn_RemoveService";
            this.Btn_RemoveService.Size = new System.Drawing.Size(55, 53);
            this.Btn_RemoveService.TabIndex = 3;
            this.Btn_RemoveService.Text = "Remove selected";
            this.Btn_RemoveService.UseVisualStyleBackColor = true;
            this.Btn_RemoveService.Click += new System.EventHandler(this.Btn_RemoveService_Click);
            // 
            // Txt_Code
            // 
            this.Txt_Code.Location = new System.Drawing.Point(12, 27);
            this.Txt_Code.Name = "Txt_Code";
            this.Txt_Code.Size = new System.Drawing.Size(171, 20);
            this.Txt_Code.TabIndex = 4;
            // 
            // Lb_Code
            // 
            this.Lb_Code.AutoSize = true;
            this.Lb_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_Code.Location = new System.Drawing.Point(9, 6);
            this.Lb_Code.Name = "Lb_Code";
            this.Lb_Code.Size = new System.Drawing.Size(116, 18);
            this.Lb_Code.TabIndex = 5;
            this.Lb_Code.Text = "Code of probe";
            // 
            // Btn_GenerateCode
            // 
            this.Btn_GenerateCode.Location = new System.Drawing.Point(108, 53);
            this.Btn_GenerateCode.Name = "Btn_GenerateCode";
            this.Btn_GenerateCode.Size = new System.Drawing.Size(75, 23);
            this.Btn_GenerateCode.TabIndex = 6;
            this.Btn_GenerateCode.Text = "Generate";
            this.Btn_GenerateCode.UseVisualStyleBackColor = true;
            this.Btn_GenerateCode.Click += new System.EventHandler(this.Btn_GenerateCode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(399, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Patient";
            // 
            // Cmb_Patients
            // 
            this.Cmb_Patients.FormattingEnabled = true;
            this.Cmb_Patients.Location = new System.Drawing.Point(12, 155);
            this.Cmb_Patients.Name = "Cmb_Patients";
            this.Cmb_Patients.Size = new System.Drawing.Size(204, 21);
            this.Cmb_Patients.TabIndex = 9;
            // 
            // Btn_NewPatient
            // 
            this.Btn_NewPatient.Location = new System.Drawing.Point(12, 183);
            this.Btn_NewPatient.Name = "Btn_NewPatient";
            this.Btn_NewPatient.Size = new System.Drawing.Size(57, 23);
            this.Btn_NewPatient.TabIndex = 12;
            this.Btn_NewPatient.Text = "New";
            this.Btn_NewPatient.UseVisualStyleBackColor = true;
            // 
            // List_Services
            // 
            this.List_Services.FormattingEnabled = true;
            this.List_Services.Location = new System.Drawing.Point(284, 57);
            this.List_Services.Name = "List_Services";
            this.List_Services.Size = new System.Drawing.Size(183, 95);
            this.List_Services.TabIndex = 13;
            // 
            // Btn_Send
            // 
            this.Btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Send.Location = new System.Drawing.Point(383, 169);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(75, 37);
            this.Btn_Send.TabIndex = 14;
            this.Btn_Send.Text = "Send";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // AcceptBioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 219);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.List_Services);
            this.Controls.Add(this.Btn_NewPatient);
            this.Controls.Add(this.Cmb_Patients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_GenerateCode);
            this.Controls.Add(this.Lb_Code);
            this.Controls.Add(this.Txt_Code);
            this.Controls.Add(this.Btn_RemoveService);
            this.Controls.Add(this.Btn_MoveService);
            this.Controls.Add(this.Cmb_Services);
            this.Name = "AcceptBioForm";
            this.Text = "AcceptBioForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AcceptBioForm_FormClosed);
            this.Load += new System.EventHandler(this.AcceptBioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_MoveService;
        private System.Windows.Forms.Button Btn_RemoveService;
        private System.Windows.Forms.TextBox Txt_Code;
        private System.Windows.Forms.Label Lb_Code;
        private System.Windows.Forms.Button Btn_GenerateCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb_Patients;
        private System.Windows.Forms.Button Btn_NewPatient;
        public System.Windows.Forms.ComboBox Cmb_Services;
        private System.Windows.Forms.ListBox List_Services;
        private System.Windows.Forms.Button Btn_Send;
    }
}