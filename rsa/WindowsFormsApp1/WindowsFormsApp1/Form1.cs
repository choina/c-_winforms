using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Helpers;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private RSAHelper _rsa = null;
        public Form1()
        {
            InitializeComponent();
    }

        private void mniKeySize512_CheckedChanged(object sender, EventArgs e)
        {
            var mniState = ((ToolStripMenuItem)sender).Checked;
            if (mniState) changeCheckMenuItems(sender, false);
        }

        private void changeCheckMenuItems(object sender, bool chacked)
        {
            foreach (var item in mniKeySize.DropDownItems)
            {
                ((ToolStripMenuItem)item).CheckedChanged -= mniKeySize512_CheckedChanged;
            }

            foreach (var item in mniKeySize.DropDownItems)
            {
                if (item != sender)
                {
                    ((ToolStripMenuItem)item).Checked = chacked;
                }
            }

            foreach (var item in mniKeySize.DropDownItems)
            {
                ((ToolStripMenuItem)item).CheckedChanged += mniKeySize512_CheckedChanged;
            }
        }
            private void btnEncrypt_Click(object sender, EventArgs e)
            {
                if (_rsa == null)
                {
                    MessageBox.Show("Error");
                    return;
                }
                if (string.IsNullOrEmpty(txtContent.Text))
                {
                    MessageBox.Show("Error");
                    return;
                }
                try
                {
                    txtResult.Text = _rsa.EncryptString(txtContent.Text, txtPublicKey.Text);
                }
                catch (Exception ex)
                {
                    txtResult.Text = "";
                    MessageBox.Show("Error");
                }
            }

        }
}
