
namespace WSkillsRebuild1.Forms
{
    partial class AssistantForm
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
            this.Btn_AcceptBio = new System.Windows.Forms.Button();
            this.Btn_Report = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.List_CurrentOrders = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_EditOrder = new System.Windows.Forms.Button();
            this.Btn_RemoveOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_AcceptBio
            // 
            this.Btn_AcceptBio.Location = new System.Drawing.Point(13, 13);
            this.Btn_AcceptBio.Name = "Btn_AcceptBio";
            this.Btn_AcceptBio.Size = new System.Drawing.Size(120, 24);
            this.Btn_AcceptBio.TabIndex = 0;
            this.Btn_AcceptBio.Text = "Accept Biomaterial";
            this.Btn_AcceptBio.UseVisualStyleBackColor = true;
            this.Btn_AcceptBio.Click += new System.EventHandler(this.Btn_AcceptBio_Click);
            // 
            // Btn_Report
            // 
            this.Btn_Report.Location = new System.Drawing.Point(166, 12);
            this.Btn_Report.Name = "Btn_Report";
            this.Btn_Report.Size = new System.Drawing.Size(96, 25);
            this.Btn_Report.TabIndex = 1;
            this.Btn_Report.Text = "Create report";
            this.Btn_Report.UseVisualStyleBackColor = true;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(12, 193);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 2;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // List_CurrentOrders
            // 
            this.List_CurrentOrders.FormattingEnabled = true;
            this.List_CurrentOrders.Location = new System.Drawing.Point(217, 95);
            this.List_CurrentOrders.Name = "List_CurrentOrders";
            this.List_CurrentOrders.Size = new System.Drawing.Size(263, 121);
            this.List_CurrentOrders.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(374, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current orders";
            // 
            // Btn_EditOrder
            // 
            this.Btn_EditOrder.Location = new System.Drawing.Point(136, 95);
            this.Btn_EditOrder.Name = "Btn_EditOrder";
            this.Btn_EditOrder.Size = new System.Drawing.Size(75, 23);
            this.Btn_EditOrder.TabIndex = 5;
            this.Btn_EditOrder.Text = "Edit order";
            this.Btn_EditOrder.UseVisualStyleBackColor = true;
            // 
            // Btn_RemoveOrder
            // 
            this.Btn_RemoveOrder.Location = new System.Drawing.Point(128, 193);
            this.Btn_RemoveOrder.Name = "Btn_RemoveOrder";
            this.Btn_RemoveOrder.Size = new System.Drawing.Size(83, 23);
            this.Btn_RemoveOrder.TabIndex = 6;
            this.Btn_RemoveOrder.Text = "Remove order";
            this.Btn_RemoveOrder.UseVisualStyleBackColor = true;
            this.Btn_RemoveOrder.Click += new System.EventHandler(this.Btn_RemoveOrder_Click);
            // 
            // AssistantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 228);
            this.Controls.Add(this.Btn_RemoveOrder);
            this.Controls.Add(this.Btn_EditOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_CurrentOrders);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Report);
            this.Controls.Add(this.Btn_AcceptBio);
            this.Name = "AssistantForm";
            this.Text = "AssistantForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AssistantForm_FormClosed);
            this.Load += new System.EventHandler(this.AssistantForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_AcceptBio;
        private System.Windows.Forms.Button Btn_Report;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.ListBox List_CurrentOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_EditOrder;
        private System.Windows.Forms.Button Btn_RemoveOrder;
    }
}