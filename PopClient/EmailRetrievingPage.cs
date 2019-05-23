using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PopClient
{
    public partial class EmailRetrievingPage : Form
    {
        private bool connected = false;
        private Pop3Client client;
        private Message message;
        
        public EmailRetrievingPage()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            connected = true;
            client = new Pop3Client();
            //Connect to Pop3 Server
            if (!client.Connect())
            {
                ErrorHandling.ConnectionError();
                connected = false;
            }
            //Login to Pop3 Server
            if(!client.Login(emailText.Text, passwordText.Text))
            {
                ErrorHandling.LoginError();
                connected = false;
            }
            //Getting mail count
            int mailCount = client.GetMailCount();
            if(mailCount != -1)
            {
                numbOfMails.Text = numbOfMails.Text + " " + mailCount.ToString();
                for(int i = 1; i <= mailCount; i++)
                {
                    comboBox1.Items.Add(i);
                }
            }
            disconnectButton.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connected)
            {
                //Getting the selected message number
                int msgNumber = (int)comboBox1.SelectedItem;
                message = client.GetMessage(msgNumber);
                messageBox.Text = message.GetBody();
                subjectText.Text = message.GetSubject();
                fromText.Text = message.GetFrom();
            }
            else ErrorHandling.NotConnectedError();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            //Disconnecting from the server
            client.Disconnect();
            connected = false;
            disconnectButton.Visible = false;
            numbOfMails.Text = "Number of Email Messages";
            comboBox1.Items.Clear();
            ClearFields();
           
        }
        private void ClearFields()
        {
            messageBox.Text = String.Empty;
            subjectText.Text = String.Empty;
            fromText.Text = String.Empty;
        }
    }
}
