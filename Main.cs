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
using System.Windows.Shapes;

namespace Website_Tools
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void httpheader_Click(object sender, EventArgs e)
        {
            if (websiteTB.Text == "")
            {
                MessageBox.Show("Please enter a website!", "Cacti");
            }
            else
                try
                {
                    WebClient client = new WebClient(); //Webclient var
                    var response = client.DownloadString($"https://api.hackertarget.com/httpheaders/?q={websiteTB.Text}"); //Uses webclient(var) to request API
                    responseTB.Clear(); //Clears the responseTB
                    responseTB.Text = ($"{response}"); //Sets responseTB to the response/result of the API

                }
                catch
                {
                    MessageBox.Show("An error has occured", "Cacti");
                }
            
        }

        private void pagelinkbutton_Click(object sender, EventArgs e)
        {
            if (websiteTB.Text == "")
            {
                MessageBox.Show("Please enter a website!", "Cacti");
            }
            else
                try
                {
                    WebClient client = new WebClient(); //Webclient var
                    var response = client.DownloadString($"https://api.hackertarget.com/pagelinks/?q={websiteTB.Text}"); //Uses webclient(var) to request API
                    responseTB.Clear(); //Clears the responseTB
                    responseTB.Text = ($"{response}"); //Sets responseTB to the response/result of the API

                }
                catch
                {
                    MessageBox.Show("An error has occured", "Cacti");
                }
        }


    }
}
