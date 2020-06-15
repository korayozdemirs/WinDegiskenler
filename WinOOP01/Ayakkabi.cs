using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOOP01
{
    //class
    class Ayakkabi
    {
        //field
        //varsayılan private
        private string _marka;

        public void MarkaYaz(string marka)
        {
            if (marka == "Adidas")
            {
                _marka = marka;
            }
        }

        public string MarkaOku()
        {
            if (_marka == null)
            {
                _marka = "Geçersiz Marka";
                return _marka;
            }
            return _marka;
        }

        private string _tip;
        //property
        //değer atamada set ; değerini okumaya çalıştığınızda get değeri çalışır.
        public string Tip
        {
            get { return _tip; }
            set { _tip = value; }
        }

        //public string malzeme;
        //prop yazıp 2 defa tab tusuna basıyoruz
        public string malzeme { get; set; }

        public int numara;
        public string renk;
    }
}
