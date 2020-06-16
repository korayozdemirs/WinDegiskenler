using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOOP4
{
    class Urun
    {
        public int Id { get; set; }
        public decimal Fiyat { get; set; }
        public virtual  decimal KdvHesapla()
        {
            return Fiyat * 1.18M;
        }
    }
}
