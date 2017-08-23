using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMinerTestFormsApp
{
    public partial class mainWindow : Form
    {
        public SocialContact sc;
        public string socialMinerCredentials;
        public mainWindow(string html, string sm)
        {
            InitializeComponent();
            outputStatic.Text = html;
            socialMinerCredentials = sm;
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            transcriptOutput.Text = "";
            sc = new SocialContact(socialMinerCredentials, socialContactIdTextBox.Text);

            agentNameTextBox.Text = sc.solicitor;
            guestNameTextBox.Text = sc.ccxName;
            guestEmailTextBox.Text = sc.ccxEmail;
            csqTextBox.Text = sc.ccxCSQ;
            chatDateTextBox.Text = sc.publishedDate.ToString();
            chatStatusTextBox.Text = sc.status.ToString();

            

            foreach (TranscriptEntry n in sc.transcript)
            {
                transcriptOutput.AppendText(n.toString());
                transcriptOutput.AppendText(Environment.NewLine);

               

                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = getTranscriptButton;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
