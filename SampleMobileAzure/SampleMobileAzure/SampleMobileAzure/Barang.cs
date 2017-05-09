using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace SampleMobileAzure
{
    public class Barang
    {
        private string _id;
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _kodeBarang;
        [JsonProperty(PropertyName = "KodeBarang")]
        public string KodeBarang
        {
            get { return _kodeBarang; }
            set { _kodeBarang = value; }
        }

        private string _namaBarang;
        [JsonProperty(PropertyName = "NamaBarang")]
        public string NamaBarang
        {
            get { return _namaBarang; }
            set { _namaBarang = value; }
        }

        private int _stok;
        [JsonProperty(PropertyName = "Stok")]
        public int Stok
        {
            get { return _stok; }
            set { _stok = value; }
        }

        private decimal _hargaBeli;
        [JsonProperty(PropertyName = "HargaBeli")]
        public decimal HargaBeli
        {
            get { return _hargaBeli; }
            set { _hargaBeli = value; }
        }

        private decimal _hargaJual;
        [JsonProperty(PropertyName = "HargaJual")]
        public decimal HargaJual
        {
            get { return _hargaJual; }
            set { _hargaJual = value; }
        }

        [Version]
        public string Version { get; set; }
    }
}