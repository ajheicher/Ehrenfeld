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
        public Campaign c;
        public string socialMinerCredentials;
        bool appStarted = true;
        public mainWindow(string html, string sm, Campaign campaign)
        {
            InitializeComponent();
            outputStatic.Text = html;
            socialMinerCredentials = sm;
            c = campaign;
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
            sc.createTranscriptLL();
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                transcriptOutput.SelectAll();
                e.Handled = e.SuppressKeyPress = true;
            }
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            Results.Items.Clear();
            List<SocialContact> searchResults = new List<SocialContact>();
            searchResults = c.newSearch(c.newSearchStringByDate(startDate.Value, endDate.Value));
            
            foreach (SocialContact s in searchResults)
            {
                Results.Items.Add(s);
            }
        }

        private void Results_SelectedIndexChanged(object sender, EventArgs e)
        {
            SocialContact s = Results.SelectedItem as SocialContact;
            transcriptOutput.Text = "";
            s.createTranscriptLL();
            agentNameTextBox.Text = s.solicitor;
            guestNameTextBox.Text = s.ccxName;
            guestEmailTextBox.Text = s.ccxEmail;
            csqTextBox.Text = s.ccxCSQ;
            chatDateTextBox.Text = s.publishedDate.ToString();
            chatStatusTextBox.Text = s.status.ToString();
            socialContactIdTextBox.Text = s.scID;

            foreach (TranscriptEntry n in s.transcript)
            {
                transcriptOutput.AppendText(n.toString());
                transcriptOutput.AppendText(Environment.NewLine);
            }

            if(s.isQAAble())
            {
                qaAbleTextBox.Text = "Yes";
            }
            else
            {
                qaAbleTextBox.Text = "No";
            }

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void rawSearchQuery_Enter(object sender, EventArgs e)
        {
            

            if (appStarted)
            {
                appStarted = false;
                rawSearchQuery.Clear();
            }
        }

        private void prevResult_Click(object sender, EventArgs e)
        {
            if (Results.SelectedIndex > 0)
            {
                Results.SelectedIndex -= 1;
            }
            else
            {
                Results.SelectedIndex = Results.Items.Count - 1;
            }
        }

        private void nextResult_Click(object sender, EventArgs e)
        {
            if (Results.SelectedIndex > -1 && Results.SelectedIndex != Results.Items.Count-1)
            {
                Results.SelectedIndex += 1;
            }
          
            else
            {
                Results.SelectedIndex = 0;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
