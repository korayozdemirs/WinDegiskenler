using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOOP4
{
    class Kazak : Urun
    {
        public string Renk { get; set; }
        public override decimal KdvHesapla()
        {
            return Fiyat * 0.08M;
        }
    }
}
