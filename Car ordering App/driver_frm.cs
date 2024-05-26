using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp;
using System.IO;

namespace Car_Ordering_App
{
    public partial class driver_form : Form
    {
        IFirebaseConfig con = new FirebaseConfig
        {
            BasePath = "https://fire-46edd-default-rtdb.firebaseio.com/",
            AuthSecret = "ANks2C01OHPDOwbIKDlIbPPnOArafnwIHtPcmoI8"
        };

        IFirebaseClient client;
        public driver_form()
        {
            InitializeComponent();
            client = new FirebaseClient(con);
        }

        private async void ref_request_bt_Click(object sender, EventArgs e)
        {
            data_Viewer.Rows.Clear();
            data_Viewer.Columns.Clear();
            data_Viewer.Columns.Add("Email","Email");
            data_Viewer.Columns.Add("Name","Name");
            data_Viewer.Columns.Add("Frome","Frome");
            data_Viewer.Columns.Add("to","to");
            data_Viewer.Columns.Add("price","price");
           
            
            
            var res = await client.GetAsync("requests/");
            Dictionary<string, requests> result = JsonConvert.DeserializeObject<Dictionary<string, requests>>(res.Body.ToString());
            foreach (var get in result)
            {
                if (get.Key == "ID") continue;
                data_Viewer.Rows.Add(get.Key,get.Value.name, get.Value.frome, get.Value.to, get.Value.price);
            }


        }
        public static string pas_name;
        public static string pas_email;
        public static string pas_frome;
        public static string pas_to;
        public static string pas_price;
        private async void driver_confirm_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(request_email_txt.Text) || string.IsNullOrEmpty(car_plate_txt.Text))
            {
                MessageBox.Show("Please complete all fields");
                return;
            }
            string rq_id = request_email_txt.Text;
            string path = "requests/" + rq_id;

            var res = await client.GetAsync(path);
            requests dt = res.ResultAs<requests>();
            if (dt == null)
            {
                MessageBox.Show("The Email is Incorrect");
            }
            else
            {
                string Driver_path = Form1.user_path.Substring(6);
                var dat = new driver_dt
                {
                    name = Form1.user_name,
                    email = Form1.user_email,
                    car_num = car_plate_txt.Text,
                };
                await client.SetAsync("accepted_rq/" + rq_id, dat); // link rq with Driver path
                await client.DeleteAsync("requests/" + rq_id);// remove user rq
                MessageBox.Show($"The request with Email: {rq_id} accepted successfully");
                pas_name = dt.name;
                pas_email = dt.email;
                pas_frome = dt.frome;
                pas_to = dt.to;
                pas_price = dt.price;
                Dr_acc_form dr_fm = new Dr_acc_form();
                this.Hide();
                dr_fm.ShowDialog();
                this.Close();
                return;
            }
        }
    }
}