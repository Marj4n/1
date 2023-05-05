using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodXYZ.type
{
    internal class Transaksi
    {
        public int Id { get; set; }
        public DateTime Tanggal { get; set; }
        public string NamaProduk { get; set; }
        public int Jumlah { get; set; }
        public double Harga { get; set; }
        public double Total { get; set; }
    }
}
