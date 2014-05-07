using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace WifiServerProgram
{
    [TestFixture]
    class ServerTest
    {
	     //Test that clicking the label makes it null

        [Test]
        public void testUserIDClick()
        {
            EventArgs e = null;
            Object sender = null;
            WifiLocator wiTest = new WifiLocator();
            //Click the button
            wiTest.userIdText_Click(sender, e);
            wiTest.passwordText_Click(sender, e);
            wiTest.macAddressText_Click(sender, e);
            wiTest.firstNameText_Click(sender, e);
            wiTest.lastNameText_Click(sender, e);
            wiTest.emailText_Click(sender, e);
            wiTest.textBox1_Click(sender, e);
            wiTest.textBox2_Click(sender, e);
            wiTest.accessPointMacAddress_Click(sender, e);
            Assert.AreEqual("", wiTest.userIdText.Text);
            Assert.AreEqual("", wiTest.passwordText.Text);
            Assert.AreEqual("", wiTest.macAddressText.Text);
            Assert.AreEqual("", wiTest.firstNameText.Text);
            Assert.AreEqual("", wiTest.lastNameText.Text);
            Assert.AreEqual("", wiTest.emailText.Text);
            Assert.AreEqual("", wiTest.accessPointName.Text);
            Assert.AreEqual("", wiTest.signalStrength.Text);

        }
        //Test connection to the database
        [Test]
        public void testUserInfo()
        {
            EventArgs e = null;
            Object sender = null;
            WifiLocator wiTest = new WifiLocator();
            wiTest.userIdText.Text = "testing...";
            wiTest.firstNameText.Text = "testing...";
            wiTest.emailText.Text = "testing...";
            wiTest.macAddressText.Text = "testing...";
            wiTest.lastNameText.Text = "testing...";
            wiTest.passwordText.Text = "testing...";
            //Click the button
            wiTest.sendToServerButton_Click(sender, e);
            String testResult = "Success!";
            Assert.AreEqual(testResult, wiTest.sendReport.Text);
        }
        //Test that a message is sent
        [Test]
        public void testListening()
        {
            EventArgs e = null;
            Object sender = null;
            WifiLocator wiTest = new WifiLocator();

            wiTest.startListeningButton_Click(sender, e);

            String testResult = "Text received!";
            Assert.AreEqual(testResult, wiTest.locationInfoLabel.Text);
        }
        //Test connection to the database
        [Test]
        public void testLocationInfo()
        {
            EventArgs e = null;
            Object sender = null;
            WifiLocator wiTest = new WifiLocator();
            wiTest.accessPointName.Text = "testing...";
            wiTest.signalStrength.Text = "testing...";
            wiTest.ssid.Text = "testing...";
            wiTest.accessPointMacAddress.Text = "testing...";
            wiTest.button1_Click(sender,e);
            String testResult = "Success!";
            Assert.AreEqual(testResult, wiTest.locationInfoLabel.Text);
        }
        //Tests to check if all the input fields were created equally:
        [Test]
        public void checkUserID()
        {
            WifiLocator wifiTest = new WifiLocator();    
            Assert.AreEqual(wifiTest.userIdText.Text,"");
        }
        [Test]
        public void checkfirstName()
        {
            WifiLocator wifiTest = new WifiLocator();
            Assert.AreEqual(wifiTest.firstNameText.Text, "");
        }
        [Test]
        public void checkemailText()
        {
            WifiLocator wifiTest = new WifiLocator();
            Assert.AreEqual(wifiTest.emailText.Text, "");
        }
        [Test]
        public void checkmacAddress()
        {
            WifiLocator wifiTest = new WifiLocator();
            Assert.AreEqual(wifiTest.macAddressText.Text, "");
        }
        [Test]
        public void checklastName()
        {
            WifiLocator wifiTest = new WifiLocator();
            Assert.AreEqual(wifiTest.lastNameText.Text, "");
        }
        [Test]
        public void checkpassword()
        {
            WifiLocator wifiTest = new WifiLocator();
            Assert.AreEqual(wifiTest.passwordText.Text, "");
        }

        

    }
}
