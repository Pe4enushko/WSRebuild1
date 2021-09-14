using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSkillsRebuild1.Forms
{
    public partial class AssistantForm : Form
    {
        public AssistantForm()
        {
            InitializeComponent();
        }

        private void AssistantForm_Load(object sender, EventArgs e)
        {
            foreach (DataRow order in DBWork.GetData("SELECT * FROM experimental.rorder WHERE orderFinished IS NULL;").Rows)
            {
                Order theOrder = new Order((int)order.ItemArray[0],(DateTime)order.ItemArray[1],
                (string)order.ItemArray[3]);
                List_CurrentOrders.Items.Add(theOrder.GetOrderString());
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssistantForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void Btn_AcceptBio_Click(object sender, EventArgs e)
        {
            AcceptBioForm acceptBioForm = new AcceptBioForm();
            acceptBioForm.Show();
        }

        private void Btn_RemoveOrder_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"ID: (\d*)*");
        }
    }
}
