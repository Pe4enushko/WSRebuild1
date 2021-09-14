using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WSkillsRebuild1.Forms
{
    public partial class AcceptBioForm : Form
    {
        public AcceptBioForm()
        {
            InitializeComponent();
        }
        private int OrderId;

        private void AcceptBioForm_Load(object sender, EventArgs e)
        {
            string[] serviceList = new string[0];
            foreach (DataRow serviceRow in DBWork.GetData("SELECT `serviceTitle` FROM experimental.`cservice`").Rows)
            {
                Array.Resize(ref serviceList,serviceList.Length + 1);
                serviceList[serviceList.Length - 1] = serviceRow[0].ToString();
            }
            Cmb_Services.Items.AddRange(serviceList);
            foreach (DataRow patient in DBWork.GetData("SELECT `patientName`,`patientLogin` FROM experimental.`rpatient`;").Rows)
            {
                Cmb_Patients.Items.Add($"{patient.ItemArray[0]} ({patient.ItemArray[1]})");
            }
        }

        private void Btn_MoveService_Click(object sender, EventArgs e)
        {
            if (Cmb_Services.SelectedItem != null)
            {
                List_Services.Items.Add((string)Cmb_Services.SelectedItem);
            }
        }

        private void Btn_RemoveService_Click(object sender, EventArgs e)
        {
            if (List_Services.SelectedIndex != -1)
            List_Services.Items.RemoveAt(List_Services.SelectedIndex);
        }

        private void Btn_GenerateCode_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ID;
            var lastID = DBWork.GetData("SELECT orderId FROM experimental.rorder ORDER BY orderId DESC LIMIT 1;");
            if ((int?)lastID.Rows[0].ItemArray[0] != null)
            {
                ID = (int)lastID.Rows[0].ItemArray[0] + 1;
                Txt_Code.Text = $"{ID}" +
                    $"{DateTime.Now.Day}{DateTime.Now.ToString("MM")}{DateTime.Now.Year}{rnd.Next(100000, 999999)}";
            }
            else
            {
                ID = 0;
                Txt_Code.Text = $"{ID}" +
                        $"{DateTime.Now.Day}{DateTime.Now.ToString("MM")}{DateTime.Now.Year}{rnd.Next(100000, 999999)}";
            }
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure you want to create this order?","Are you sure?",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Txt_Code.Text?.Length > 14 && List_Services.Items != null && Cmb_Patients.SelectedItem != null)
                {
                    Regex regex = new Regex(@"\(([^)]*)\)");
                    OrderId = int.Parse(Txt_Code.Text.Substring(0, Txt_Code.Text.Length - 14));
                    string dateString = Txt_Code.Text.Substring(Txt_Code.TextLength - 14, Txt_Code.TextLength - 7);
                    dateString = dateString.Insert(2, ".");
                    dateString = dateString.Insert(5, ".");

                    DBWork.SendOrder(OrderId,regex.Match(Cmb_Patients.SelectedItem.ToString()).Groups[1].Value,
                        List_Services.Items.Cast<string>().ToArray(),
                        DateTime.Parse(dateString));
                    MessageBox.Show("Order created","Done");
                }
                else
                {
                    MessageBox.Show("You've got unfilled fields","You forgot something");
                }
            }
        }

        private void AcceptBioForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
