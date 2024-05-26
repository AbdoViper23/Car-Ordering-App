using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Ordering_App
{
    public partial class passenger_form : Form
    {
        IFirebaseConfig con = new FirebaseConfig
        {
            BasePath = "https://fire-46edd-default-rtdb.firebaseio.com/",
            AuthSecret = "ANks2C01OHPDOwbIKDlIbPPnOArafnwIHtPcmoI8"
        };
        IFirebaseClient client;
        public passenger_form()
        {
            InitializeComponent();
            client = new FirebaseClient(con);
        }

        private async void button_request_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pick_up_tb.Text) || string.IsNullOrEmpty(txt_drop.Text) || string.IsNullOrEmpty(Trip_price_tb.Text))
            {
                MessageBox.Show("Please complete all fields");
                return;
            }
            var rq = new requests
            {
                name = Form1.user_name,
                email = Form1.user_email,
                frome = pick_up_tb.Text,
                to = txt_drop.Text,
                price = Trip_price_tb.Text
            };

            string path = "requests/" + Form1.user_email;
            var ret = await client.SetAsync(path, rq);
            Follow_request();
        }

        public static string dr_name;
        public static string dr_email;
        public static string dr_car_num;
        async void Follow_request()
        {
            string path = "accepted_rq/" + Form1.user_email;
            while (true)
            {
                await Task.Delay(2000);// sleep
                try
                {
                    var res = await client.GetAsync(path);
                    driver_dt dt = res.ResultAs<driver_dt>();
                    if (dt == null) continue;
                    MessageBox.Show("Your request has been accepted");
                    dr_name = dt.name;
                    dr_email = dt.email;
                    dr_car_num = dt.car_num;
                    request_accept_form rq_form = new request_accept_form();
                    this.Hide();
                    rq_form.ShowDialog();
                    this.Close();
                    return;
                }
                catch (Exception ex) { }
            }
        }

    }
}
