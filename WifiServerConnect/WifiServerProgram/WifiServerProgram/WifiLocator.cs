using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
//Add MySql Library
using MySql.Data.MySqlClient;


namespace WifiServerProgram
{
    public partial class WifiLocator : Form
    {


        public WifiLocator()
        {
            InitializeComponent();
        }

        public void sendToServerButton_Click(object sender, EventArgs e)
        {
            if (userIdText.Text == "" || firstNameText.Text == "" || emailText.Text == "" || macAddressText.Text == "" || lastNameText.Text == "" || passwordText.Text == "")
            {
                sendReport.Text = "Fill in all the required information!";
            }
            else if (userIdText.Text.Contains("Enter ") || firstNameText.Text.Contains("Enter ") || emailText.Text.Contains("Enter ") || macAddressText.Text.Contains("Enter ") || lastNameText.Text.Contains("Enter ") || passwordText.Text.Contains("Enter "))
            {
                sendReport.Text = "Actually enter in some information...";
            }
            else
            {
                try
                {
                    String command = "INSERT INTO UserTable (userID,password,userMacAddress,firstName,lastName,email,isAdmin) VALUES('" +
                    userIdText.Text + "','" + passwordText.Text + "','" + macAddressText.Text + "','" + firstNameText.Text + "','" + lastNameText.Text + "','" + emailText.Text + "','N')";

                    MySqlConnection connection;
                    string server;
                    string database;
                    string uid;
                    string password;

                    server = "mintaka.lynchburg.edu";
                    database = "WifiLocDja";
                    uid = "darrius_c";
                    password = "fool7BREW";
                    string connectionString;
                    connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                    sendReport.Text = "Connecting...";
                    connection = new MySqlConnection(connectionString);
                    //open connection
                    connection.Open();               
                    
                    if (connection.State.Equals(ConnectionState.Open))
                    {
                        sendReport.Text = "Connection open, executing command...";
                        //create command and assign the query and connection from the constructor
                        MySqlCommand cmd = new MySqlCommand(command, connection);
                        //Execute command
                        cmd.ExecuteNonQuery();

                        //Test #6
                        sendReport.Text = "Success!";
                        connection.Close();
                    }


                }
                catch (Exception badError)
                {
                    Console.WriteLine("Error..... " + badError.StackTrace);
                }
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (accessPointName.Text == "" || signalStrength.Text == "" || ssid.Text == "" || accessPointMacAddress.Text == "")
            {
                locationInfoLabel.Text = "Fill in all the required information!";
            }
            else if (accessPointName.Text.Contains("Enter ") || signalStrength.Text.Contains("Enter ") || ssid.Text.Contains("Enter ") || accessPointMacAddress.Text.Contains("Enter "))
            {
                locationInfoLabel.Text = "Actually enter in some information...";
            }
            else if (userIdText.Text == "" || userIdText.Text.Contains("Enter "))
            {
                locationInfoLabel.Text = "User ID not entered (change above)";
            }
            else
            {
                try
                {
                    String command = "INSERT INTO locations (accessPointName,signalStrength,macAddress,ssid,userID) VALUES('" +
                    accessPointName.Text + "','" + signalStrength.Text + "','" + accessPointMacAddress.Text + "','" + ssid.Text + "','" + userIdText.Text + "')";

                    MySqlConnection connection;
                    string server;
                    string database;
                    string uid;
                    string password;

                    server = "mintaka.lynchburg.edu";
                    database = "WifiLocDja";
                    uid = "darrius_c";
                    password = "fool7BREW";
                    string connectionString;
                    connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                    locationInfoLabel.Text = "Connecting...";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    if (connection.State.Equals(ConnectionState.Open))
                    {
                        locationInfoLabel.Text = "Connection open, executing command...";
                        //open connection
                        //create command and assign the query and connection from the constructor
                        MySqlCommand cmd = new MySqlCommand(command, connection);

                        //Execute command
                        cmd.ExecuteNonQuery();

                        //Test #8
                        locationInfoLabel.Text = "Success!";
                        connection.Close();
                    }


                }
                catch (Exception badError)
                {
                    Console.WriteLine("Error..... " + badError.StackTrace);
                }
            }
        }

        public void startListeningButton_Click(object sender, EventArgs e)
        {
            listenLabel.Text = "Starting listening...";
            string data = null;
            byte[] bytes = new Byte[1024];


            stopListening = false;
            IPHostEntry ipHostInfo = Dns.Resolve("localhost");
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5001);
            listenLabel.Text = "Local endpoint: " + localEndPoint.ToString();

            /* Start Listeneting at the specified port */

            Socket listener = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
            //Socket s = myList.AcceptSocket();

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                
                // Start listening for connections.
                while (true)
                {
                    listenLabel.Text = "The server is running at port 5001, waiting for a connection.....";
                    // Program is suspended while waiting for an incoming connection.
                    Socket handler = listener.Accept();
                    data = null;

                    // An incoming connection needs to be processed.
                    while (true)
                    {
                        bytes = new byte[1024];
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }

                    // Show the data on the console.
                    listenLabel.Text = "Text received!";

                    // Echo the data back to the client.
                    byte[] msg = Encoding.ASCII.GetBytes(data);

                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e3)
            {
                Console.WriteLine(e.ToString());
            } 
    }
        public void userIdText_Click(object sender, EventArgs e)
        {
            userIdText.Text = "";
        }

        public void passwordText_Click(object sender, EventArgs e)
        {
            passwordText.Text = "";
        }

        public void macAddressText_Click(object sender, EventArgs e)
        {
            macAddressText.Text = "";
        }

        public void firstNameText_Click(object sender, EventArgs e)
        {
            firstNameText.Text = "";
        }

        public void lastNameText_Click(object sender, EventArgs e)
        {
            lastNameText.Text = "";
        }

        public void emailText_Click(object sender, EventArgs e)
        {
            emailText.Text = "";
        }

        public void textBox1_Click(object sender, EventArgs e)
        {
            accessPointName.Text = "";
        }

        public void quitButton_click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void textBox2_Click(object sender, EventArgs e)
        {
            signalStrength.Text = "";
        }

        public void textBox3_Click(object sender, EventArgs e)
        {
            ssid.Text = "";
        }

        public void accessPointMacAddress_Click(object sender, EventArgs e)
        {
            accessPointMacAddress.Text = "";
        }

        public void stopListeningButton_Click(object sender, EventArgs e)
        {
            stopListening = true;
        }

        public bool stopListening = true;

    }
}
