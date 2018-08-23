using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Security;
using MetroFramework.Forms;

namespace password_generator
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void generate(int length, int alpha)
        {
            string password = Membership.GeneratePassword(length, alpha);
            output.Text = password;
            Clipboard.SetText(password);
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int i = new int();
            Int32.TryParse(length.Text, out i);
            int j = new int();
            Int32.TryParse(alpha.Text, out i);
            generate(i, j);
        }
    }
}
