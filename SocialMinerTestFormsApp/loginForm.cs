using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;

namespace SocialMinerTestFormsApp
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void signIn_Click(object sender, EventArgs e)
        {
            //TODO: Fix this garbage you heathan
            string loginUsername = username.Text;
            string loginPassword = password.Text;
            string smCredentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(loginUsername + ":" + loginPassword));

            Campaign chat = new Campaign(smCredentials, "http://10.171.1.100/ccp-webapp/ccp/campaign/CCX_Chat_Campaign/");

            this.Hide();
            mainWindow main = new mainWindow(chat.output.ToString(), smCredentials, chat);
           
            main.Show();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = signIn;
        }
    }
}
