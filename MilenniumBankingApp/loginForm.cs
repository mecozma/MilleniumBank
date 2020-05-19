using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilenniumBankingApp
{
    public partial class loginForm : Form
    {
        Form customer_details = new customer_details();
        public loginForm()
        {
            InitializeComponent();
        }
        String username = "admin";
        String password = "admin";
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            String username_value = username_textBox.Text;
            String password_value = password_textBox.Text;

            if(username_value == "" && password_value == "")
            {
                MessageBox.Show("Please insert a valid username and password");
            } else
            {
                MessageBox.Show("You can only see your balance" + password_value);
                customer_details.Show();
            } 
            
        }
    }
}
