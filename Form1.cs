using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DiscordRPC;
using System.IO.IsolatedStorage;


namespace apiClient
{



    public partial class Form1 : Form
    {
        public string myUsername = "";
        public bool adminMode = false;
        public int oldRequestCount = 0;
        public int newRequestCount = 0;
        void recieve()
        {

            var url = "https://api.isaacthoman.me/api/App";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();





            // this allows our worker to report progress during work
            bw.WorkerReportsProgress = true;

            // what to do in the background thread
            bw.DoWork += new DoWorkEventHandler(
            delegate (object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;

                // do some simple processing for 10 seconds


                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    args.Result = result.Trim('"');
                    return;
                }

            });


            // what to do when worker completes its task (notify the user)
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
            delegate (object o, RunWorkerCompletedEventArgs args)
            {



                string test1 = (string)args.Result;
                test1 = test1.Replace("@newline", "" + System.Environment.NewLine);
                string[] array = test1.Split(Environment.NewLine);
                array = array.Reverse().Take(17).ToArray();

                msgDisplayLabel.Text = string.Join(System.Environment.NewLine, array.Reverse());



            });
            if (bw.IsBusy==false) {
                bw.RunWorkerAsync();
            }


            if (adminMode) {
                recieveAdmin(1);
            }
            
        }

        void recieveAdmin(int type)//just use 1 please
        {
            var url3 = "https://api.isaacthoman.me/api/admin?token=" + tokenBox.Text + "&requestType="+type;


            var httpRequest3 = (HttpWebRequest)WebRequest.Create(url3);
            var httpResponse3 = (HttpWebResponse)httpRequest3.GetResponse();





            // this allows our worker to report progress during work
            bw2.WorkerReportsProgress = true;

            // what to do in the background thread
            bw2.DoWork += new DoWorkEventHandler(
            delegate (object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;


                using (var streamReader = new StreamReader(httpResponse3.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    args.Result = result.Trim('"');
                    return;
                }

            });


            // what to do when worker completes its task (notify the user)
            bw2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
            delegate (object o, RunWorkerCompletedEventArgs args)
            {



                    string test1 = (string)args.Result;
                test1 = test1.Replace("@newline", "" + System.Environment.NewLine);
                string[] array = test1.Split(Environment.NewLine);
                if (array.Length > 1) { lastMsgBox.Text = array.SkipLast(1).Last(); }

                array = array.Reverse().Take(22).ToArray();


                    consoleDisplayLabel.Text = string.Join(System.Environment.NewLine, array.Reverse());




            });
            if (bw2.IsBusy == false)
            {
                bw2.RunWorkerAsync();
            }




        }





        void send()
        {
            string sendString = "";
            if (usernameBox.Text == "")
            {
                sendString = msgBox.Text;
            }
            else
            {
                sendString = usernameBox.Text + ": " + msgBox.Text;

            }


            var url1 = "https://api.isaacthoman.me/api/App?message=" + sendString;

            var httpRequest1 = (HttpWebRequest)WebRequest.Create(url1);
            httpRequest1.Method = "POST";
            httpRequest1.ContentType = "text/plain";
            httpRequest1.Headers["Content-Length"] = "0";
            var httpResponse1 = (HttpWebResponse)httpRequest1.GetResponse();





            bw1.WorkerReportsProgress = true;

            // what to do in the background thread
            bw1.DoWork += new DoWorkEventHandler(
            delegate (object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;

                using (var streamReader1 = new StreamReader(httpResponse1.GetResponseStream()))
                {
                    var result = streamReader1.ReadToEnd();
                    args.Result = result;
                    return;
                }


            });


            // what to do when worker completes its task (notify the user)
            bw1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
            delegate (object o, RunWorkerCompletedEventArgs args)
            {
                //s   textBox1.Text = (string)args.Result;
            });

            bw1.RunWorkerAsync();


        }

        void sendConsole(string message)
        {
            string sendString = "@@CLRDATA";

                sendString = message;


            var url1 = "https://api.isaacthoman.me/api/admin?token="+tokenBox.Text+"&message="+sendString;

            var httpRequest1 = (HttpWebRequest)WebRequest.Create(url1);
            httpRequest1.Method = "POST";
            httpRequest1.ContentType = "text/plain";
            httpRequest1.Headers["Content-Length"] = "0";
            var httpResponse1 = (HttpWebResponse)httpRequest1.GetResponse();





            bw3.WorkerReportsProgress = true;

            // what to do in the background thread
            bw3.DoWork += new DoWorkEventHandler(
            delegate (object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;

                using (var streamReader1 = new StreamReader(httpResponse1.GetResponseStream()))
                {
                    var result = streamReader1.ReadToEnd();
                    args.Result = result;
                    return;
                }


            });


            // what to do when worker completes its task (notify the user)
            bw3.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
            delegate (object o, RunWorkerCompletedEventArgs args)
            {
                //s   textBox1.Text = (string)args.Result;
            });

            bw3.RunWorkerAsync();


        }

        BackgroundWorker bw = new BackgroundWorker();
        BackgroundWorker bw1 = new BackgroundWorker();
        BackgroundWorker bw2 = new BackgroundWorker();
        BackgroundWorker bw3 = new BackgroundWorker();
        BackgroundWorker bw4 = new BackgroundWorker();

        public Form1()
        {

            

            InitializeComponent();

            DiscordRpcClient client = new DiscordRpcClient("827968201451110510");

            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = "Open to channel 0",
              //  State = "Why isn't the yellow Beanchat dude showing up in discord?!? >:(",
                Assets = new Assets()
                {
                    LargeImageKey = "appicon1",
                    LargeImageText = "👌😎👍",
                   // SmallImageKey = "appicon1"
                }
            });

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            recieve();

          

        }

        private void button2_Click(object sender, EventArgs e)
        {

            send();
            recieve();
            msgBox.Text = "";
            msgBox.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


            this.Size = new Size(400, 420);
            usernameGroup.Text = "";
            mainGroup.Text = "";
            mainGroup.Location = new Point(0, -10);
            usernameGroup.Location = new Point(600, 50);
            consoleGroup.Location = new Point(600, 50);
            adminGroup.Location = new Point(600, 50);


           
                refreshTimer.Enabled = true;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            recieve();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void usernameSubmitBtn_Click(object sender, EventArgs e)
        {
            mainGroup.Location = new Point(0, -10);
            usernameGroup.Location = new Point(600, 50);
            myUsername = usernameBox.Text;
            refreshTimer.Enabled = true;
            this.Text = "Beanchat";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consoleSendBtn_Click(object sender, EventArgs e)
        {
            
            sendConsole(consoleBox2.Text.ToString());
            consoleBox2.Text = "";
            recieve();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sendConsole("CLRDATA");
        }

        private void adminModeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (adminModeBox.Checked)
            {

                adminMode = true;
                mainGroup.Location = new Point(12, 12);
                consoleGroup.Location = new Point(418, 12);

                usernameGroup.Location = new Point(824,12);
                adminGroup.Location = new Point(824, 210);
                this.Size = new Size(1248, 464);
                this.Text = "Beanchat";
                settingsBtn.Visible = false;
                settingsExitBtn.Visible = false;
                usernameGroup.Text = "Settings";
                mainGroup.Text = "Main";
                //requestsChecker.Enabled = true;
            }
            else
            {

                adminMode = false;

                this.Size = new Size(400, 420);
                usernameGroup.Text = "";
                mainGroup.Text = "";


                usernameGroup.Size = new Size(400, 400);
                mainGroup.Location = new Point(600, 50);
                usernameGroup.Location = new Point(0, -10);
                consoleGroup.Location = new Point(600, 50);
                adminGroup.Location = new Point(600, 50);


                this.Text = "Beanchat";
                settingsBtn.Visible = true;
                settingsExitBtn.Visible = true;

                requestsChecker.Enabled = false;
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(400, 420);

            usernameGroup.Size = new Size(400,400);
            mainGroup.Location = new Point(600,50);
            usernameGroup.Location = new Point(0, -10);
            consoleGroup.Location = new Point(600, 50);
            adminGroup.Location = new Point(600, 50);

        }

        private void settingsExitBtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(400, 420);

            usernameGroup.Size = new Size(400, 192);
            mainGroup.Location = new Point(0,-10);
            usernameGroup.Location = new Point(600, 50);
            consoleGroup.Location = new Point(600, 50);
            adminGroup.Location = new Point(600, 50);

        }

        private void requestsChecker_Tick(object sender, EventArgs e)
        {

           // clientsLabel.Text = newRequestCount.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
