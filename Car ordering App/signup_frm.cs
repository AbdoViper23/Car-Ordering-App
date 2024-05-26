using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Car_Ordering_App
{
    public partial class signup_frm : Form
    {
        IFirebaseConfig con = new FirebaseConfig
        {
            BasePath = "https://fire-46edd-default-rtdb.firebaseio.com/",
            AuthSecret = "ANks2C01OHPDOwbIKDlIbPPnOArafnwIHtPcmoI8"
        };
        IFirebaseClient client;
        public signup_frm()
        {
            InitializeComponent();
            client = new FirebaseClient(con);
        }

        private void back_bt_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        private async void signup_bt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name_tb.Text) || string.IsNullOrEmpty(Email_tb.Text) || string.IsNullOrEmpty(pass_tb.Text))
            {
                MessageBox.Show("Please complete all fields");
            }
            else
            {
                var dat = new user_dt
                {
                    name = name_tb.Text,
                    email = Email_tb.Text,
                    password = pass_tb.Text,
                };
                string path = "newUsers/" +Email_tb.Text;
                var rs = await client.SetAsync(path, dat);
                MessageBox.Show("Registration Done Successfully");
                Form1 form = new Form1();// go to home page
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}
