using SharpCifs.Smb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ITtools.UI.MasteData
{
    public partial class FrmUpload : Form
    {
        public FrmUpload()
        {
            InitializeComponent();
        }

        private void tsbUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                //using System.Text;
                //using SharpCifs.Smb;

                string fileName = openFileDialog.SafeFileName;

                //Get the SmbFile specifying the file name to be created.
                var file = new SmbFile("smb://jing.luo:ximai_2016@192.168.10.200/software/"+ fileName);

                //Create file.
                file.CreateNewFile();

                //Get writable stream.
                var writeStream = file.GetOutputStream();

                //Write bytes.
                writeStream.Write(File.ReadAllBytes(openFileDialog.FileName));
                //writeStream.Write()

                //Dispose writable stream.
                writeStream.Dispose();
                MessageBox.Show("文件上传成功");
            }
        }
    }
}
