using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace Tugas3Dicoding
{
    public class Storage
    {
        [PrimaryKey, AutoIncrement]
        public long StoId { get; set; }
        [NotNull]
        public string jenisTransaksi { get; set; }
        public int amountTransaksi { get; set; }
        public string dateTransaksi { get; set; }
        public string infoTransaksi { get; set; }
    }
}
