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
    public partial class Frm_directoryBac : Form
    {
        public Frm_directoryBac()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(this.closeParent);
        }

        private void btn_openFileDirectory_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
              
                txt_directory.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeParent(object sender,FormClosedEventArgs formClosedEventArgs)
        {
            this.Parent.Dispose();
        }
    }
}
