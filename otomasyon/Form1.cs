using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace otomasyon
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig{
            AuthSecret = "qjm7y7fEiLu9dg77oEk1wlmtYNhv92FU7C7T2CSg",
        BasePath = "https://otomasyon-b9b89-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }
        static bool connectionControl()
        {
            try
            {
                return new System.Net.NetworkInformation.Ping().Send("www.google.com", 1000).Status == System.Net.NetworkInformation.IPStatus.Success;
            }
            catch (Exception)
            {

               return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (connectionControl() == false)
            {
                MessageBox.Show("Connection failed: No Internet connection.");
                this.Close();
            }
            else
            {
                client = new FireSharp.FirebaseClient(config);
                if (client == null)
                {
                    MessageBox.Show("Firebase Connection: Failed");
                }
            }
           
        }

        private void stockTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newStockEntry_Click(object sender, EventArgs e)
        {
            frmNewStorageEntry frm = new frmNewStorageEntry();
            frm.Show();
        }

        private void storageListMenuItem_Click(object sender, EventArgs e)
        {
            frmStorageList frm = new frmStorageList();
            frm.Show();
        }
    }
}
