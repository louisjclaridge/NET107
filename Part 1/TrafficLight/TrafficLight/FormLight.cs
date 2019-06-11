using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;


//************************************************************************//
// This project makes an extremely simple traffic light.  Because of the  //
// personal firewall on the lab computers being switched on, this         //
// actually connects to a sort of proxy (running in my office) that       //
// accepts the incomming  connection.                                     //    
// By Nigel.                                                              //
//                                                                        //
// Please use this code, sich as it is,  for any eduactional or non       //
// profit making research porposes on the conditions that.                //
//                                                                        //
// 1.    You may only use it for educational and related research         //
//      pusposes.                                                         //
//                                                                        //
// 2.   You leave my name on it.                                          //
//                                                                        //
// 3.   You correct at least 10% of the typig and spekking mistskes.      //
//                                                                        //
// © Nigel Barlow nigel@soc.plymouth.ac.uk 2018                           //
//************************************************************************//

namespace TrafficLight
{
    public partial class FormTrafficLight : Form
    {
        public FormTrafficLight()
        {
            InitializeComponent();
        }


        //******************************************************//
        // Nigel Networking attributes.                         //
        //******************************************************//
        private int              serverPort       = 5000;
        private int              bufferSize       = 200;
        private TcpClient        socketClient     = null;
        private String           serverName       = "jackparsons.me";  
        private NetworkStream    connectionStream = null;
        private BinaryReader     inStream         = null;
        private BinaryWriter     outStream        = null;
        private ThreadConnection threadConnection = null;
		string id = "0";
		int carsSent = 0;


        //*******************************************************************//
        // This one is needed so that we can post messages back to the form's//
        // thread and don't violate C#'s threading rule that says you can    //
        // only touch the UI components from the form's thread.              //
        //*******************************************************************//
        SynchronizationContext uiContext = null;
    




        //*********************************************************************//
        // Form load.  Display an IP. Or a series of IPs.                      //                               
        //*********************************************************************//
        private void Form1_Load(object sender, EventArgs e)
        {
            //******************************************************************//
            //All this to find out IP number.                                   //
            //******************************************************************//
            IPHostEntry localHostInfo = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());

            listBoxOutput.Items.Add("You may have many IP numbers.");
            listBoxOutput.Items.Add("In the Plymouth labs, use the IP that looks like an IP4 number");
            listBoxOutput.Items.Add("something like 10.xx.xx.xx.");
            listBoxOutput.Items.Add("If at home using a VPN use the IP4 number that starts");
            listBoxOutput.Items.Add("something like 141.163.xx.xx");
            listBoxOutput.Items.Add(" ");


            foreach (IPAddress address in localHostInfo.AddressList)
                listBoxOutput.Items.Add(address.ToString());


            //******************************************************************//
            // Get the SynchronizationContext for the current thread (the form's//
            // thread).                                                         //
            //******************************************************************//
            uiContext = SynchronizationContext.Current;
            if (uiContext == null)
                listBoxOutput.Items.Add("No context for this thread");
            else
                listBoxOutput.Items.Add("We got a context");
 
        }



        //*********************************************************************//
        // Form closing.  If the connection thread was ever created then kill  //
        // it off.                                                             //                               
        //*********************************************************************//
        private void FormTrafficLight_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadConnection != null) threadConnection.StopThread();
        }



        //*********************************************************************//
        // Message was posted back to us.  This is to get over the C# threading//
        // rules whereby we can only touch the UI components from the thread   //
        // that created them, which is the form's main thread.                 // 
        //*********************************************************************//
        public void MessageReceived(Object received)
        {
            String message = (String) received;
            listBoxOutput.Items.Add(message);
            ChangeLights(message);
            Console.WriteLine(message);
			understandMessage(message);//Call understand message to see what the message wants us to do

        }
		public void understandMessage(string message)
		{
			string[] localWords = message.Split(',');//Split up the message
			if (id == "0" && carsSent == 1) // See if it is the first time a message has been sent, if so, assign an id
			{
				
				if (message.Contains("Id"))
				{

					id = localWords[1];
				}

			}
			if (localWords[1] == "change" )//Change the lights
			{

				
				string[] words = message.Split(',');
				int numberInt = Convert.ToInt32(words[3]);
				int upperPair = numberInt + 2;//Find upper and lower pairs
				int lowerPair = numberInt - 2;
				if (words[3] == id || upperPair.ToString() == id || lowerPair.ToString() == id)// is the message for me?
				{
					if (words[2] == "GreenOff")//Check to see what the message wants us to do
					{
						labelGreen.Visible = false;//Do it
						sendString(","+"changed" + "," + "GreenOff" + "," + id,textBoxLightIP.Text);//Return what we did
					}
					if (words[2] == "GreenOn")
					{
						labelGreen.Visible = true;
						sendString("," + "changed" + "," + "GreenOn" + "," + id, textBoxLightIP.Text);
					}
					if (words[2] == "AmberOff")
					{
						labelAmber.Visible = false;
						sendString("," + "changed" + "," + "AmberOff" + "," + id, textBoxLightIP.Text);
					}
					if (words[2] == "AmberOn" && labelGreen.Visible == false && labelRed.Visible == false)
					{
						labelAmber.Visible = true;
						sendString("," + "changed" + "," + "AmberOn" + "," + id, textBoxLightIP.Text);
					}

					if (words[2] == "RedOff")
					{
						labelRed.Visible = false;
						sendString("," + "changed" + "," + "RedOff" + "," + id, textBoxLightIP.Text);
					}
					if (words[2] == "RedOn")
					{
						labelRed.Visible = true;
						sendString("," + "changed" + "," + "RedOn" + "," + id, textBoxLightIP.Text);
					}
				}
			}
		
			

		}



        //*********************************************************************//
        // Change the status of the lights.                                    //
        //*********************************************************************//
        private void ChangeLights(String command)
        {
            //if (command == null) return;    // Nothing to do.
           
            //if (command.Contains("Red"))   labelRed.Visible   = true;
            //if (command.Contains("Amber")) labelAmber.Visible = true;
            //if (command.Contains("Green")) labelGreen.Visible = true;
        }



        //*********************************************************************//
        // The OnClick for the "connect"command button.  Create a new client   //
        // socket.   Much of this code is exception processing.                //
        //*********************************************************************//
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                socketClient = new TcpClient(serverName, serverPort);
            }
            catch (Exception ee)
            {
                listBoxOutput.Items.Add("Error in connecting to server");     //Console is a sealed object; we
                listBoxOutput.Items.Add(ee.Message);				 	      //can't make it, we can just access
                labelStatus.Text = "Error " + ee.Message;
                labelStatus.BackColor = Color.Red;
            }

            if (socketClient == null)
            {
                listBoxOutput.Items.Add("Socket not connected");

            }
            else
            {

                //**************************************************//
                // Make some streams.  They have rather more        //
                // capabilities than just a socket.  With this type //
                // of socket, we can't read from it and write to it //
                // directly.                                        //
                //**************************************************//
                connectionStream = socketClient.GetStream();
                inStream  = new BinaryReader(connectionStream);
                outStream = new BinaryWriter(connectionStream);

                listBoxOutput.Items.Add("Socket connected to " + serverName);

                labelStatus.BackColor = Color.Green;
                labelStatus.Text = "Connected to " + serverName;


                //**********************************************************//
                // Discale connect button (we can only connect once) and    //
                // enable other components.                                 //
                //**********************************************************//
                buttonConnect.Enabled    = false;
                buttonCarArrived.Enabled = true;


                //***********************************************************//
                //We have now accepted a connection.                         //
                //                                                           //
                //There are several ways to do this next bit.   Here I make a//
                //network stream and use it to create two other streams, an  //
                //input and an output stream.   Life gets easier at that     //
                //point.                                                     //
                //***********************************************************//
                threadConnection = new ThreadConnection(uiContext, socketClient, this);


                //***********************************************************//
                // Create a new Thread to manage the connection that receives//
                // data.  If you are a Java programmer, this looks like a    //
                // load of hokum cokum..                                     //
                //***********************************************************//
                Thread threadRunner = new Thread(new ThreadStart(threadConnection.Run));
                threadRunner.Start();

                Console.WriteLine("Created new connection class");
            }
        }




        //**********************************************************************//
        // Button cluck for the car arrived button.  All it does is send the    //
        // string "Car" to the server.                                          //
        //**********************************************************************//
        private void buttonCarArrived_Click(object sender, EventArgs e)
        {
            sendString("," + id + "," +"Car", textBoxLightIP.Text);//Sent cars to the server

			carsSent++;
        }



        //**********************************************************************//
        // Send a string to the IP you give.  The string and IP are bundled up  //
        // into one of there rather quirky Nigel style packets.                 // 
        //                                                                      //
        // This uses the pre-defined stream outStream.  If this strean doesn't  //
        // exist then this method will bomb.                                    //
        //                                                                      //
        // It also does the networking synchronously, in the form's main        //
        // Thread.  This is not good practise; all networking should really be  //
        // asynchronous.                                                        //
        //**********************************************************************//
        private void sendString(String stringToSend, String sendToIP)
        {

            try
            {
                byte[] packet = new byte[bufferSize];
                String[] ipStrings = sendToIP.Split('.'); //Split with . as separator

                packet[0] = Byte.Parse(ipStrings[0]);
                packet[1] = Byte.Parse(ipStrings[1]);   //Think about this.  It assumes the user
                packet[2] = Byte.Parse(ipStrings[2]);   //has entered the IP corrrectly, and 
                packet[3] = Byte.Parse(ipStrings[3]);   //sends the numbers without the bytes.

                int bufferIndex = 4;                    //Start assembling message

                //**************************************************************//
                // Turn the string into an array of characters.                 //
                //**************************************************************//
                int length = stringToSend.Length;
                char[] chars = stringToSend.ToCharArray();


                //**************************************************************//
                // Then turn each character into a byte and copy into my packet.//
                //**************************************************************//
                for (int i = 0; i < length; i++)
                {
                    byte b = (byte)chars[i];
                    packet[bufferIndex] = b;
                    bufferIndex++;
                }

                packet[bufferIndex] = 0;    //End of packet (even though it is always 200 bytes)

                outStream.Write(packet, 0, bufferSize);
                listBoxOutput.Items.Add("Sent " + stringToSend);
            }
            catch (Exception doh)
            {
                listBoxOutput.Items.Add("An error occurred: " + doh.Message);
            }

        }

		private void btnId_Click(object sender, EventArgs e)
		{
			//sendString("id",textBoxLightIP.Text);
		}
	}   // End of classy class.
}   // End of namespace
