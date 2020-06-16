using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOOP2
{
    class AhmetButton : ButtonBase, IButtonControl
    {
        public DialogResult DialogResult { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void NotifyDefault(bool value)
        {
            throw new NotImplementedException();
        }

        public void PerformClick()
        {
            throw new NotImplementedException();
        }
    }
}
