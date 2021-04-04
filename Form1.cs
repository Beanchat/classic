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

namespace apiClient
{



    public partial class Form1 : Form
    {

        void recieve()
        {

            var url = "http://api.beanchat.isaacthoman.me/api/App";

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

                label1.Text = string.Join(System.Environment.NewLine, array.Reverse());



            });

            bw.RunWorkerAsync();



        }


        void send()
        {

            var sendString = textBox1.Text;

            var url1 = "http://api.beanchat.isaacthoman.me/api/App?message=" + sendString;

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

        BackgroundWorker bw = new BackgroundWorker();
        BackgroundWorker bw1 = new BackgroundWorker();

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
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            recieve();
        }


    }
}
