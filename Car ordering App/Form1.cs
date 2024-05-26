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
    public partial class Form1 : Form
    {
        IFirebaseConfig con = new FirebaseConfig
        {
            BasePath = "https://fire-46edd-default-rtdb.firebaseio.com/",
            AuthSecret = "ANks2C01OHPDOwbIKDlIbPPnOArafnwIHtPcmoI8"
        };
        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
            client = new FirebaseClient(con);
        }

        private void signup_bt_Click(object sender, EventArgs e)
        {
            signup_frm sf = new signup_frm();
            this.Hide();
            sf.ShowDialog();
            this.Close();
        }

        public static string user_path;
        public static string user_name;
        public static string user_email;
        private async void login_bt_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(email_tb.Text) || string.IsNullOrEmpty(pass_tb.Text))
            {
                MessageBox.Show("Please complete all fields");
            }
            else
            {
                string path = "newUsers/" + email_tb.Text;
                try
                {
                    var rs = await client.GetAsync(path);
                    user_dt us = rs.ResultAs<user_dt>();
                    if (us == null)
                    {
                        MessageBox.Show("There is Wrong With Your Email or Password");
                    }
                    else if (us.password == pass_tb.Text)
                    {
                        user_path = "newUsers/" + us;
                        user_name = us.name;
                        user_email = us.email;
                        welcome_frm w_fm = new welcome_frm();
                        this.Hide();
                        w_fm.ShowDialog();
                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("There is Wrong With Your Email or Password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There is Wrong With Your Email or Password");
                }
            }
        }
    }
}
