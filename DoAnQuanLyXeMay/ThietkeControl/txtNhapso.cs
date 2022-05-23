using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietkeControl
{
    public class txtNhapso:TextBox
    {
        public txtNhapso()
        {
            this.KeyPress += txt_sdt_KeyPress;
        }
        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
