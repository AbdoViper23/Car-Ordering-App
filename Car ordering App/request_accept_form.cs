using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Car_Ordering_App
{
    public partial class request_accept_form : Form
    {
        IFirebaseConfig con = new FirebaseConfig
        {
            BasePath = "https://fire-46edd-default-rtdb.firebaseio.com/",
            AuthSecret = "ANks2C01OHPDOwbIKDlIbPPnOArafnwIHtPcmoI8"
        };

        IFirebaseClient client;
        public request_accept_form()
        {
            InitializeComponent();
            client = new FirebaseClient(con);
        }

        private void request_accept_form_Load(object sender, EventArgs e)
        {
            this.dr_name_lb2.Text =passenger_form.dr_name;
            this.dr_car_lb2.Text = passenger_form.dr_car_num;
            this.Dr_email_lb2.Text =passenger_form.dr_email;

            live_msg();

        }

        async void live_msg()
        {
            while (true)
            {
            await Task.Delay(1000);// sleep
                try
                {
                    var rs = await client.GetAsync("chat/" + passenger_form.dr_email);
                    string txt = rs.ResultAs<string>();
                    if (string.IsNullOrEmpty(txt)) continue;
                    string msg = "Driver: " + txt + "\n\n";
                    msg_tx.Text += msg;
                    client.DeleteAsync("chat/" + passenger_form.dr_email);
                }
                catch (Exception ex) { }
            }
        }

        private void Back_bt_Click(object sender, EventArgs e)
        {
            passenger_form form = new passenger_form();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        private async void Send_bt_Click(object sender, EventArgs e)
        {
            string txt = new_msg_tb.Text;
            new_msg_tb.Text = "";
            string msg = "You: " + txt + "\n\n";
            msg_tx.Text += msg;
            await client.SetAsync("chat/" + Form1.user_email, txt);
        }

    }
}
