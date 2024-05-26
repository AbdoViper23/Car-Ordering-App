using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
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
    public partial class welcome_frm : Form
    {
        IFirebaseConfig con = new FirebaseConfig
        {
            BasePath = "https://fire-46edd-default-rtdb.firebaseio.com/",
            AuthSecret = "ANks2C01OHPDOwbIKDlIbPPnOArafnwIHtPcmoI8"
        };

        IFirebaseClient client;
        public welcome_frm()
        {
            InitializeComponent();
            client = new FirebaseClient(con);
        }

        private async void welcome_frm_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Welcome "+ Form1.user_name;
        }

        private void driver_bt_Click(object sender, EventArgs e)
        {
            driver_form form = new driver_form();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void passenger_bt_Click(object sender, EventArgs e)
        {
            passenger_form form = new passenger_form();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
