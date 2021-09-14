
namespace WSkillsRebuild1
{
    partial class LoginForm
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
            this.Cmb_Position = new System.Windows.Forms.ComboBox();
            this.Txt_Login = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cmb_Position
            // 
            this.Cmb_Position.FormattingEnabled = true;
            this.Cmb_Position.Items.AddRange(new object[] {
            "patient",
            "assistant",
            "accountant",
            "admin"});
            this.Cmb_Position.Location = new System.Drawing.Point(150, 51);
            this.Cmb_Position.Name = "Cmb_Position";
            this.Cmb_Position.Size = new System.Drawing.Size(99, 21);
            this.Cmb_Position.TabIndex = 0;
            this.Cmb_Position.SelectedIndexChanged += new System.EventHandler(this.Cmb_Position_SelectedIndexChanged);
            // 
            // Txt_Login
            // 
            this.Txt_Login.Location = new System.Drawing.Point(11, 52);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(100, 20);
            this.Txt_Login.TabIndex = 1;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(12, 112);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(100, 20);
            this.Txt_Password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pass";
            // 
            // Btn_Check
            // 
            this.Btn_Check.Location = new System.Drawing.Point(150, 112);
            this.Btn_Check.Name = "Btn_Check";
            this.Btn_Check.Size = new System.Drawing.Size(75, 23);
            this.Btn_Check.TabIndex = 5;
            this.Btn_Check.Text = "Check";
            this.Btn_Check.UseVisualStyleBackColor = true;
            this.Btn_Check.Click += new System.EventHandler(this.Btn_Check_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 150);
            this.Controls.Add(this.Btn_Check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_Login);
            this.Controls.Add(this.Cmb_Position);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "LoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmb_Position;
        private System.Windows.Forms.TextBox Txt_Login;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Check;
    }
}

