using System.Windows.Forms;

namespace otomasyon
{
    internal class Data 
    {
        internal static Data result;
        public int storageId { get; set; }
        public string storageName { get; set; }
        public string storageUnit { get; set; }
        public int storageBuyingPrice { get; set; }
        public int storageSellingPrice { get; set; }
        public string description { get; set; }
    }
}