namespace WifiServerProgram
{
    partial class WifiLocator
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
            this.userIdText = new System.Windows.Forms.TextBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.macAddressText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.sendToServerButton = new System.Windows.Forms.Button();
            this.sendReport = new System.Windows.Forms.Label();
            this.accessPointName = new System.Windows.Forms.TextBox();
            this.signalStrength = new System.Windows.Forms.TextBox();
            this.ssid = new System.Windows.Forms.TextBox();
            this.sendLocationInformation = new System.Windows.Forms.Button();
            this.locationInfoLabel = new System.Windows.Forms.Label();
            this.accessPointMacAddress = new System.Windows.Forms.TextBox();
            this.connectedDevicesText = new System.Windows.Forms.Label();
            this.clientList = new System.Windows.Forms.ListBox();
            this.startListeningButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopListeningButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listenLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userIdText
            // 
            this.userIdText.Location = new System.Drawing.Point(32, 41);
            this.userIdText.Name = "userIdText";
            this.userIdText.Size = new System.Drawing.Size(143, 20);
            this.userIdText.TabIndex = 1;
            this.userIdText.Click += new System.EventHandler(this.userIdText_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(32, 164);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(143, 20);
            this.firstNameText.TabIndex = 2;
            this.firstNameText.Click += new System.EventHandler(this.firstNameText_Click);
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(32, 253);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(143, 20);
            this.emailText.TabIndex = 4;
            this.emailText.Click += new System.EventHandler(this.emailText_Click);
            // 
            // macAddressText
            // 
            this.macAddressText.Location = new System.Drawing.Point(32, 125);
            this.macAddressText.Name = "macAddressText";
            this.macAddressText.Size = new System.Drawing.Size(143, 20);
            this.macAddressText.TabIndex = 3;
            this.macAddressText.Click += new System.EventHandler(this.macAddressText_Click);
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(32, 206);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(143, 20);
            this.lastNameText.TabIndex = 6;
            this.lastNameText.Click += new System.EventHandler(this.lastNameText_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(32, 86);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(143, 20);
            this.passwordText.TabIndex = 5;
            this.passwordText.Click += new System.EventHandler(this.passwordText_Click);
            // 
            // sendToServerButton
            // 
            this.sendToServerButton.Location = new System.Drawing.Point(269, 215);
            this.sendToServerButton.Name = "sendToServerButton";
            this.sendToServerButton.Size = new System.Drawing.Size(164, 58);
            this.sendToServerButton.TabIndex = 7;
            this.sendToServerButton.Text = "Send User Information";
            this.sendToServerButton.UseVisualStyleBackColor = true;
            this.sendToServerButton.Click += new System.EventHandler(this.sendToServerButton_Click);
            // 
            // sendReport
            // 
            this.sendReport.AutoSize = true;
            this.sendReport.Location = new System.Drawing.Point(29, 288);
            this.sendReport.Name = "sendReport";
            this.sendReport.Size = new System.Drawing.Size(269, 13);
            this.sendReport.TabIndex = 8;
            this.sendReport.Text = "Click Send To Send User Information To The Database";
            // 
            // accessPointName
            // 
            this.accessPointName.Location = new System.Drawing.Point(32, 339);
            this.accessPointName.Name = "accessPointName";
            this.accessPointName.Size = new System.Drawing.Size(185, 20);
            this.accessPointName.TabIndex = 9;
            this.accessPointName.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // signalStrength
            // 
            this.signalStrength.Location = new System.Drawing.Point(32, 381);
            this.signalStrength.Name = "signalStrength";
            this.signalStrength.Size = new System.Drawing.Size(185, 20);
            this.signalStrength.TabIndex = 10;
            this.signalStrength.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // ssid
            // 
            this.ssid.Location = new System.Drawing.Point(32, 423);
            this.ssid.Name = "ssid";
            this.ssid.Size = new System.Drawing.Size(185, 20);
            this.ssid.TabIndex = 11;
            this.ssid.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // sendLocationInformation
            // 
            this.sendLocationInformation.Location = new System.Drawing.Point(269, 439);
            this.sendLocationInformation.Name = "sendLocationInformation";
            this.sendLocationInformation.Size = new System.Drawing.Size(164, 46);
            this.sendLocationInformation.TabIndex = 12;
            this.sendLocationInformation.Text = "Send Location Information";
            this.sendLocationInformation.UseVisualStyleBackColor = true;
            this.sendLocationInformation.Click += new System.EventHandler(this.button1_Click);
            // 
            // locationInfoLabel
            // 
            this.locationInfoLabel.AutoSize = true;
            this.locationInfoLabel.Location = new System.Drawing.Point(29, 503);
            this.locationInfoLabel.Name = "locationInfoLabel";
            this.locationInfoLabel.Size = new System.Drawing.Size(288, 13);
            this.locationInfoLabel.TabIndex = 13;
            this.locationInfoLabel.Text = "Click Send To Send Location Information To The Database";
            // 
            // accessPointMacAddress
            // 
            this.accessPointMacAddress.Location = new System.Drawing.Point(32, 465);
            this.accessPointMacAddress.Name = "accessPointMacAddress";
            this.accessPointMacAddress.Size = new System.Drawing.Size(185, 20);
            this.accessPointMacAddress.TabIndex = 14;
            this.accessPointMacAddress.Click += new System.EventHandler(this.accessPointMacAddress_Click);
            // 
            // connectedDevicesText
            // 
            this.connectedDevicesText.AutoSize = true;
            this.connectedDevicesText.Location = new System.Drawing.Point(451, 24);
            this.connectedDevicesText.Name = "connectedDevicesText";
            this.connectedDevicesText.Size = new System.Drawing.Size(104, 13);
            this.connectedDevicesText.TabIndex = 15;
            this.connectedDevicesText.Text = "Connected Devices:";
            // 
            // clientList
            // 
            this.clientList.FormattingEnabled = true;
            this.clientList.Location = new System.Drawing.Point(454, 41);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(120, 95);
            this.clientList.TabIndex = 16;
            // 
            // startListeningButton
            // 
            this.startListeningButton.Location = new System.Drawing.Point(454, 135);
            this.startListeningButton.Name = "startListeningButton";
            this.startListeningButton.Size = new System.Drawing.Size(120, 55);
            this.startListeningButton.TabIndex = 17;
            this.startListeningButton.Text = "Start Listening...";
            this.startListeningButton.UseVisualStyleBackColor = true;
            this.startListeningButton.Click += new System.EventHandler(this.startListeningButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.commandsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitButton});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitButton
            // 
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(97, 22);
            this.quitButton.Text = "Quit";
            this.quitButton.Click += new System.EventHandler(this.quitButton_click);
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // stopListeningButton
            // 
            this.stopListeningButton.Location = new System.Drawing.Point(454, 187);
            this.stopListeningButton.Name = "stopListeningButton";
            this.stopListeningButton.Size = new System.Drawing.Size(120, 39);
            this.stopListeningButton.TabIndex = 19;
            this.stopListeningButton.Text = "Stop Listening";
            this.stopListeningButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter User Email...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Enter User Last Name...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Enter User First Name...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Enter User Mac Address...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Enter User Password...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Enter User Id...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Enter Access Point Mac Address...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Enter SSID...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Enter Signal Strength...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Enter Access Point Name...";
            // 
            // listenLabel
            // 
            this.listenLabel.AutoSize = true;
            this.listenLabel.Location = new System.Drawing.Point(454, 259);
            this.listenLabel.Name = "listenLabel";
            this.listenLabel.Size = new System.Drawing.Size(79, 13);
            this.listenLabel.TabIndex = 30;
            this.listenLabel.Text = "Not Connected";
            // 
            // WifiLocator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 538);
            this.Controls.Add(this.listenLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopListeningButton);
            this.Controls.Add(this.startListeningButton);
            this.Controls.Add(this.clientList);
            this.Controls.Add(this.connectedDevicesText);
            this.Controls.Add(this.accessPointMacAddress);
            this.Controls.Add(this.locationInfoLabel);
            this.Controls.Add(this.sendLocationInformation);
            this.Controls.Add(this.ssid);
            this.Controls.Add(this.signalStrength);
            this.Controls.Add(this.accessPointName);
            this.Controls.Add(this.sendReport);
            this.Controls.Add(this.sendToServerButton);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.macAddressText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.userIdText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WifiLocator";
            this.Text = "Wifi Locator Server Panel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Test #5
        public System.Windows.Forms.TextBox userIdText;
        public System.Windows.Forms.TextBox firstNameText;
        public System.Windows.Forms.TextBox emailText;
        public System.Windows.Forms.TextBox macAddressText;
        public System.Windows.Forms.TextBox lastNameText;
        public System.Windows.Forms.TextBox passwordText;
        //Test #3
        public System.Windows.Forms.Button sendToServerButton;

        public System.Windows.Forms.Label sendReport;

        //Test #7
        public System.Windows.Forms.TextBox accessPointName;
        public System.Windows.Forms.TextBox signalStrength;
        public System.Windows.Forms.TextBox ssid;
        public System.Windows.Forms.Button sendLocationInformation;
        //Needs to be public to run tests
        public System.Windows.Forms.Label locationInfoLabel;
        public System.Windows.Forms.TextBox accessPointMacAddress;
        public System.Windows.Forms.Label connectedDevicesText;
        public System.Windows.Forms.ListBox clientList;
        public System.Windows.Forms.Button startListeningButton;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem quitButton;
        public System.Windows.Forms.Button stopListeningButton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label listenLabel;

    }
}

