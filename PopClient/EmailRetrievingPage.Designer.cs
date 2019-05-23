namespace PopClient
{
    partial class EmailRetrievingPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fromText2 = new System.Windows.Forms.Label();
            this.fromText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.subjectText = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numbOfMails = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fromText2);
            this.panel1.Controls.Add(this.fromText);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.subjectText);
            this.panel1.Controls.Add(this.messageBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 527);
            this.panel1.TabIndex = 2;
            // 
            // fromText2
            // 
            this.fromText2.AutoSize = true;
            this.fromText2.Location = new System.Drawing.Point(0, 40);
            this.fromText2.Name = "fromText2";
            this.fromText2.Size = new System.Drawing.Size(44, 17);
            this.fromText2.TabIndex = 5;
            this.fromText2.Text = "From:";
            // 
            // fromText
            // 
            this.fromText.Location = new System.Drawing.Point(0, 63);
            this.fromText.Name = "fromText";
            this.fromText.Size = new System.Drawing.Size(492, 22);
            this.fromText.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Body:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Subject:";
            // 
            // subjectText
            // 
            this.subjectText.Location = new System.Drawing.Point(0, 110);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(492, 22);
            this.subjectText.TabIndex = 1;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(3, 176);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(489, 339);
            this.messageBox.TabIndex = 0;
            this.messageBox.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.disconnectButton);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.numbOfMails);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(498, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 234);
            this.panel2.TabIndex = 3;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(110, 161);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(108, 29);
            this.disconnectButton.TabIndex = 7;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Visible = false;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Choose which message to display";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numbOfMails
            // 
            this.numbOfMails.AutoSize = true;
            this.numbOfMails.Location = new System.Drawing.Point(9, 34);
            this.numbOfMails.Name = "numbOfMails";
            this.numbOfMails.Size = new System.Drawing.Size(180, 17);
            this.numbOfMails.TabIndex = 4;
            this.numbOfMails.Text = "Number of Email Messages";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.connectButton);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.passwordText);
            this.panel3.Controls.Add(this.emailText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(498, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 293);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(127, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(110, 229);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(108, 29);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your email";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(57, 151);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(185, 22);
            this.passwordText.TabIndex = 1;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(57, 88);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(185, 22);
            this.emailText.TabIndex = 0;
            // 
            // EmailRetrievingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 527);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmailRetrievingPage";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subjectText;
        private System.Windows.Forms.Label numbOfMails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label fromText2;
        private System.Windows.Forms.TextBox fromText;
    }
}

