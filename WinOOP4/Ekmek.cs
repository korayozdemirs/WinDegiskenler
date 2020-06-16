using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOOP4
{
    class Ekmek : Urun
    {
        public string Tür { get; set; }
        public override decimal KdvHesapla()
        {
            return Fiyat * 0.18M;
        }
    }
}
