using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace otomasyon
{
    public partial class frmStorageList : Form
    {
        public frmStorageList()
        {
            InitializeComponent();
        }

        private async void frmStorageList_Load(object sender, EventArgs e)
        {
            //IFirebaseConfig config = new FirebaseConfig
            //{
            //    AuthSecret = "qjm7y7fEiLu9dg77oEk1wlmtYNhv92FU7C7T2CSg",
            //    BasePath = "https://otomasyon-b9b89-default-rtdb.firebaseio.com/"
            //};
            //IFirebaseClient  client = new FirebaseClient(config);
            //var data = await client.GetTaskAsync("Stok");
            //Dictionary<string,Data> dataDic = data.ResultAs<Dictionary<string,Data>>();

            //foreach(var item in dataDic)
            //{
            //    dataGridView1.Rows.Add(item.Value.storageId,item.Value.storageName, item.Value.storageUnit, item.Value.storageBuyingPrice, item.Value.storageSellingPrice, item.Value.description);

            //}
        }
    }
}
