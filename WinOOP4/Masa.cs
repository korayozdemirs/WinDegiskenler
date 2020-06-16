using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOOP4
{
    class Masa : Urun
    {
        public string Malzeme { get; set; }
        public override decimal KdvHesapla()
        {
            return Fiyat * 1.18M;
        }
    }
}
