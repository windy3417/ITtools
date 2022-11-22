using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITtools.UI
{
    public partial class FrmDecrypt : Form
    {
        public FrmDecrypt()
        {
            InitializeComponent();
            this.FormClosed += closeParentForm;
        }

        private void closeParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = Utility.Encrypt.Decode(RtbEncryptCharacter.Text);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbEncrypt_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = Utility.Encrypt.Encode(RtbEncryptCharacter.Text);
        }

        private void tsbDecrypt_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = Utility.Encrypt.Decode(RtbEncryptCharacter.Text);
        }
    }
}
