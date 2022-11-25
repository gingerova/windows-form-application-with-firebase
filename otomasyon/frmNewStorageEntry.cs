using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class frmNewStorageEntry : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "qjm7y7fEiLu9dg77oEk1wlmtYNhv92FU7C7T2CSg",
            BasePath = "https://otomasyon-b9b89-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public frmNewStorageEntry()
        {
            InitializeComponent();
        }
        
        private void frmNewStorageEntry_Load(object sender, EventArgs e)
        {
            txtSellingPrice.Text = "0";
            txtBuyingPrice.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
               storageId= int.Parse(txtId.Text),
               storageName=txtName.Text,
               storageUnit=cmbUnit.Text,
               storageBuyingPrice=int.Parse(txtBuyingPrice.Text),
               storageSellingPrice=int.Parse(txtSellingPrice.Text),
               description= txtDescription.Text
            };
            client = new FireSharp.FirebaseClient(config);
            SetResponse resp = await client.SetTaskAsync("Stok/"+txtId.Text,data);
            Data.result = resp.ResultAs<Data>();
            ClearFrm();
        }

        public void ClearFrm()
        {
            txtBuyingPrice.Text= "0";
            txtDescription.Text="";
            txtId.Text= "";
            txtName.Text = "";
            txtSellingPrice.Text = "0";

        }
    }
}
