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
// This project makes an extremely simple server to connect to the other  //
// traffic light clients.  Because of the personal firewall on the lab    //
// computers being switched on, the server cannot use a listening socket  //
// accept incomming connections.  So the server to actually connects to a //
// sort of proxy (running in my office) that accepts the incomming        //
// connection.                                                            //    
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

namespace TrafficLightServer
{

    //New wrapper class.
    public delegate void UI_UpdateHandler(String message);

    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
        }


        //******************************************************//
        // Nigel Networking attributes.                         //
        //******************************************************//
        private int              serverPort       = 5000;
        private int              bufferSize       = 200;
        private TcpClient        socketClient     = null;
        private String           serverName       = "jackparsons.me";  //A computer in my office.eeyore.fost.plymouth.ac.uk
		private NetworkStream    connectionStream = null;
        private BinaryReader     inStream         = null;
        private BinaryWriter     outStream        = null;
        private ThreadConnection threadConnection = null;
		private int[] numberCar = new int[] {0,0,0,0,0};//Array for cars
		private int lightId = 0;

        //*******************************************************************//
        // This one is needed so that we can post messages back to the form's//
        // thread and don't violate C#'s threading rule that says you can    //
        // only touch the UI components from the form's thread.              //
        //*******************************************************************//
        private SynchronizationContext uiContext = null;



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
                listBoxOutput.Items.Add(ee.Message);				 	       //can't make it, we can just access
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
                inStream         = new BinaryReader(connectionStream);
                outStream        = new BinaryWriter(connectionStream);

                listBoxOutput.Items.Add("Socket connected to " + serverName);

                labelStatus.BackColor = Color.Green;
                labelStatus.Text = "Connected to " + serverName;


                //**********************************************************//
                // Discale connect button (we can only connect once) and    //
                // enable other components.                                 //
                //**********************************************************//
                buttonConnect.Enabled       = false;

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
                Thread threadRunner = new Thread(new ThreadStart(threadConnection.run));
                threadRunner.Start();

                Console.WriteLine("Created new connection class");

            }
        }






        //*********************************************************************//
        // The item in the combo box has been changed.  Transmit it.           // 
        //*********************************************************************//


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
                int length   = stringToSend.Length;
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
                //listBoxOutput.Items.Add("An error occurred: " + doh.Message);
				//Caused crashes?
            }

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
            Console.WriteLine(message);
			understandMessage(message);//understand the message
        }

		public void understandMessage(string Message)
		{
			string[] words = Message.Split(',');//Split message
			if (words[1] == "0")//If id is blank
			{
				
				lightId++;//Set id
				numberCar[lightId]++;//Increase the lights car by one
				
				sendString("Id" + "," + lightId + ",", textBoxLightIP.Text);//Send a new id
				sendString(","+"change" +"," + "RedOn" + "," + lightId + ",", textBoxLightIP.Text);//Turn red
				switch (lightId) {//Say connected when connected
					case 1:
						lblLightOneConnected.Text = "Connected";
						lblLightOneRed.Visible = true;
						lblLight1Red.Visible = true;
						break;
					case 2:
						lblLightTwoConnected.Text = "Connected";
						lblLightTwoRed.Visible = true;
						lblLight2Red.Visible = true;
						break;
					case 3:
						lblLightThreeConnected.Text = "Connected";
						lblLightThreeRed.Visible = true;
						lblLight3Red.Visible = true;
						break;
					case 4:
						lblLightFourConnected.Text = "Connected";
						lblLightFourRed.Visible = true;
						lblLight4Red.Visible = true;
						break;


				}

			}
			if (Message.Contains("Car"))//If it is a car
			{

		
					numberCar[Convert.ToInt32(words[1])]++;//Increase that lights cars by one
				//Update car texts
				lblLight1Cars.Text = numberCar[1].ToString();
				lblLight2Cars.Text = numberCar[2].ToString();
				lblLight3Cars.Text = numberCar[3].ToString();
				lblLight4Cars.Text = numberCar[4].ToString();
				if (numberCar[Convert.ToInt32(words[1])] == 10)//If there are 10 cars
				{
					
					numberCar[Convert.ToInt32(words[1])] = 0;//Reset cars
					new Thread(() =>//start a new thread to stop the system from freezing
					{
						Thread.CurrentThread.IsBackground = true;//Make it a background thread
						int nextOne = Convert.ToInt32(words[1]) + 1;//Find the oppisite pair
						//Do trafic light logic to switch the pairs
						sendString(","+"change" + "," + "RedOff" + "," + words[1] + ",", textBoxLightIP.Text);
						sendString(","+"change" + "," + "AmberOn" + "," + words[1] + "," + "change" + ",", textBoxLightIP.Text);
						sendString("," + "change" + "," + "GreenOff" + "," + nextOne + "," + "change" + ",", textBoxLightIP.Text);
						sendString("," + "change" + "," + "AmberOn" + "," + nextOne + "," + "change" + ",", textBoxLightIP.Text);
						System.Threading.Thread.Sleep(3000);
						sendString("," + "change" + "," + "AmberOff" + "," + nextOne + "," + "change" + ",", textBoxLightIP.Text);
						sendString("," + "change" + "," + "RedOn" + "," + nextOne + "," + "change" + ",", textBoxLightIP.Text);
						sendString(","+"change" + "," + "AmberOff" + "," + words[1] + "," + "change" + ",", textBoxLightIP.Text);
						sendString(","+"change" + "," + "GreenOn" + "," + words[1] + "," + "change" + ",", textBoxLightIP.Text);


					}).Start();


					

				}
				

			}
			if (words[1] == "reset")//Reset
			{
				numberCar[Convert.ToInt32(words[2])] = 0;
			}
			if (words[1] == "changed")//If a light has changed, do the big switch statement
			{
				//Make the UI lights work :)
				switch (Convert.ToInt32(words[3]))
				{
					case 1:
						if (words[2] == "GreenOff")
						{
							lblLight1Green.Visible = false;
							lblLightOneGreen.Visible = false;
						}
						if (words[2] == "GreenOn")
						{
							lblLight1Green.Visible = true;
							lblLightOneGreen.Visible = true;
						}
						if (words[2] == "AmberOff")
						{
							lblLight1Amber.Visible = false;
							lblLightOneAmber.Visible = false;
						}
						if (words[2] == "AmberOn")
						{
							lblLight1Amber.Visible = true;
							lblLightOneAmber.Visible = true;
						}
						if (words[2] == "RedOff")
						{
							lblLight1Red.Visible = false;
							lblLightOneRed.Visible = false;
						}
						if (words[2] == "RedOn")
						{
							lblLight1Red.Visible = true;
							lblLightOneRed.Visible = true;
						}


						break;
					case 2:
						if (words[2] == "GreenOff")
						{
							lblLight2Green.Visible = false;
							lblLightTwoGreen.Visible = false;
						}
						if (words[2] == "GreenOn")
						{
							lblLight2Green.Visible = true;
							lblLightTwoGreen.Visible = true;
						}
						if (words[2] == "AmberOff")
						{
							lblLight2Amber.Visible = false;
							lblLightTwoAmber.Visible = false;
						}
						if (words[2] == "AmberOn")
						{
							lblLight2Amber.Visible = true;
							lblLightTwoAmber.Visible = true;
						}
						if (words[2] == "RedOff")
						{
							lblLight2Red.Visible = false;
							lblLightTwoRed.Visible = false;
						}
						if (words[2] == "RedOn")
						{
							lblLight2Red.Visible = true;
							lblLightTwoRed.Visible = true;
						}


						break;
					case 3:
						if (words[2] == "GreenOff")
						{
							lblLight3Green.Visible = false;
							lblLightThreeGreen.Visible = false;
						}
						if (words[2] == "GreenOn")
						{
							lblLight3Green.Visible = true;
							lblLightThreeGreen.Visible = true;
						}
						if (words[2] == "AmberOff")
						{
							lblLight3Amber.Visible = false;
							lblLightThreeAmber.Visible = false;
						}
						if (words[2] == "AmberOn")
						{
							lblLight3Amber.Visible = true;
							lblLightThreeAmber.Visible = true;
						}
						if (words[2] == "RedOff")
						{
							lblLight3Red.Visible = false;
							lblLightThreeRed.Visible = false;
						}
						if (words[2] == "RedOn")
						{
							lblLight3Red.Visible = true;
							lblLightThreeRed.Visible = true;
						}


						break;
					case 4:
						if (words[2] == "GreenOff")
						{
							lblLight4Green.Visible = false;
							lblLightFourGreen.Visible = false;
						}
						if (words[2] == "GreenOn")
						{
							lblLight4Green.Visible = true;
							lblLightFourGreen.Visible = true;
						}
						if (words[2] == "AmberOff")
						{
							lblLight4Amber.Visible = false;
							lblLightFourAmber.Visible = false;
						}
						if (words[2] == "AmberOn")
						{
							lblLight4Amber.Visible = true;
							lblLightFourAmber.Visible = true;
						}
						if (words[2] == "RedOff")
						{
							lblLight4Red.Visible = false;
							lblLightFourRed.Visible = false;
						}
						if (words[2] == "RedOn")
						{
							lblLight4Red.Visible = true;
							lblLightFourRed.Visible = true;
						}


						break;
				}
			}
		}




        //*********************************************************************//
        // Form closing.  If the connection thread was ever created then kill  //
        // it off.                                                             //                               
        //*********************************************************************//
        private void FormServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadConnection != null) threadConnection.StopThread();
        }

        
 
    }   // End of classy class.
}       // End of namespace
