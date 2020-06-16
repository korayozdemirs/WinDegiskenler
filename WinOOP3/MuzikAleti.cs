using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOOP3
{
    public abstract class MuzikAleti
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public abstract string Ses();
    }
}
