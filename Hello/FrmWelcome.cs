using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C# rocks!", "Welcome",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
