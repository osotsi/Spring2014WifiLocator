using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace dummyandroidclient
{
    [TestFixture]
    class dummyTest
    {
        //Only test needed: at the end the label will change if the client sent a message
        //to the server and received one in turn.
        [Test]
        public void testConnect()
        {
            EventArgs e = null;
            Object sender = null;
            androidPhone wiTest = new androidPhone();

            wiTest.button1_Click(sender, e);
            String testResult = "Echoed test";
            Assert.AreEqual(testResult, wiTest.locationInfoLabel.Text);
        }
		
		//Test the initial label was created successfully
		[Test]
        public void checkemailText()
        {
            androidPhone wiTest = new androidPhone();
            Assert.AreEqual(wiTest.statusLabel.Text, "System Status: No message sent");
        }
    }
}
