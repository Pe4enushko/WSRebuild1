using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace WSkillsRebuild1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private string Position { get; set; }
        private void Btn_Check_Click(object sender, EventArgs e)
        {
            var connection = DBWork.CreateConnection();
            if (DBWork.CheckLogin(Txt_Login.Text,Txt_Password.Text,Position))
            {
                switch (Position)
                {
                    case "assistant":
                        {
                            Forms.AssistantForm assistantForm = new Forms.AssistantForm();
                            assistantForm.Show();
                            //this.Close();
                            this.Hide();
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Invalid login or password","Not today :(");
            }
        }

        private void Cmb_Position_SelectedIndexChanged(object sender, EventArgs e)
        {
            Position = Properties.Settings.Default.Position = Cmb_Position.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Position = Properties.Settings.Default.Position;
            Cmb_Position.SelectedItem = Properties.Settings.Default.Position;
        }
    }
}
