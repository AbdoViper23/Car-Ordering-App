using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace Car_Ordering_App
{
    public partial class Dr_acc_form : Form
    {
        IFirebaseConfig con = new FirebaseConfig
        {
            BasePath = "https://fire-46edd-default-rtdb.firebaseio.com/",
            AuthSecret = "ANks2C01OHPDOwbIKDlIbPPnOArafnwIHtPcmoI8"
        };
        IFirebaseClient client;
        public Dr_acc_form()
        {
            InitializeComponent();
            client = new FirebaseClient(con);
        }

        private void Dr_acc_form_Load(object sender, EventArgs e)
        {
            this.pas_email_lb2.Text = driver_form.pas_email;
            this.pas_frome_lb2.Text = driver_form.pas_frome;
            this.pas_name_lb2.Text = driver_form.pas_name;
            this.pas_to_lb2.Text = driver_form.pas_to;
            this.pas_price_lb2.Text = driver_form.pas_price;
            live_msg();
        }

        async void live_msg()
        {
            while (true)
            {
                await Task.Delay(1000);// sleep
                try
                {
                    var rs = await client.GetAsync("chat/" + driver_form.pas_email);
                    string txt = rs.ResultAs<string>();
                    if (string.IsNullOrEmpty(txt)) continue;
                    string msg = "passenger: " + txt + "\n\n";
                    msg_tx.Text += msg;
                    client.DeleteAsync("chat/" + driver_form.pas_email);
                }
                catch (Exception ex) { }
            }
        }
        private async void End_trip_lb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("trip was finished successfully");
            string path = "accepted_rq/"+driver_form.pas_email;
            var rs = await client.DeleteAsync(path);
            driver_form form =new driver_form();
            this.Hide();
            form.ShowDialog();
            this.Close();
            return;
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
