using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITtools.UI.Tools
{
    public partial class FrmDownload : Form
    {
        public FrmDownload()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();
            txtFileDirectory.Text = o.FileName;
        }

        private void tsbTransfer_Click(object sender, EventArgs e)
        {
            byte[] f = File.ReadAllBytes(txtFileDirectory.Text);

            if (f != null)
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = txtFileName.Text;
                saveFileDialog.Filter = "Excel Files(*.xls;*.xlsx)|*.xls;*.xlsx|PDF Files(*.pdf)|*pdf|Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, f);
                }


            }
        }
    }
}
