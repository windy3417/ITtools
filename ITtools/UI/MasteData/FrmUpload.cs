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
using ITtools.Model.IT;
using Directory = System.IO.Directory;
using System.Diagnostics;

namespace ITtools.UI.MasteData
{
    public partial class FrmUpload : Form
    {
        public FrmUpload()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;


        }

        public Action<bool> ActionUploadSuccessFlag;


        /// <summary>
        /// received voucherId for saving or query
        /// </summary>
        public string VoucherId { get; set; }

        /// <summary>
        /// upload files to smb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //using System.Text;
                //using SharpCifs.Smb;

                string fileName = openFileDialog.SafeFileName;

                //Get the SmbFile specifying the file name to be created.
                var file = new SmbFile("smb://jing.luo:ximai_2016@192.168.10.200/software/Attachment/weakCurrent" + fileName);

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

        /// <summary>
        /// save files to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UploadFile(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //using System.Text;
                    //using SharpCifs.Smb;

                    string fileName = openFileDialog.SafeFileName;

                    using (ItContext context = new ItContext())
                    {
                        using (var stream = openFileDialog.OpenFile())
                        {
                            byte[] fileContent = new byte[stream.Length];
                            stream.Read(fileContent, 0, fileContent.Length);

                            // Create a new File object and add it to the context
                            AttachFiles file = new AttachFiles()
                            {
                                VoucherID = this.VoucherId,
                                Name = fileName,
                                Content = fileContent

                            };

                            context.AttachFiles.Add(file);
                            context.SaveChanges();
                        }
                    }

                    MessageBox.Show("文件上传成功");
                    ReadAttachFiles(this.VoucherId);
                    ActionUploadSuccessFlag?.Invoke(true);




                }
            }
            catch (Exception)
            {

                throw;
            }


        }



        #region crud

        void ReadAttachFiles(string voucherId)
        {
            using (ItContext db = new ItContext())
            {
                var q = db.AttachFiles.Where(s => s.VoucherID == voucherId).Select(m => new { m.VoucherID, m.Name, m.Id });

                dataGridView1.DataSource = q.ToList();
            }
        }


        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (ItContext db = new ItContext())
                {
                    var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                    var m = db.AttachFiles.Where(w => w.Id == id).FirstOrDefault();
                    db.AttachFiles.Remove(m);
                    db.SaveChanges();
                    MessageBox.Show("删除成功！");
                    ReadAttachFiles(this.VoucherId);
                }
            }
            catch (Exception)
            {

                throw;
            } 
        }

        #endregion


        private void FrmUpload_Load(object sender, EventArgs e)
        {
            ReadAttachFiles(this.VoucherId);
            dataGridView1.AutoResizeColumns();
        }

        /// <summary>
        /// open files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (ItContext db = new ItContext())
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                string parentPath = "temp" + "/";
                string  fileName = db.AttachFiles.Where(w => w.Id == id).Select(s => s.Name).FirstOrDefault();
                string writeFilePath = parentPath + fileName; // 相对路径
                string readFilePath = "temp" + "\\" + fileName;                                             
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), writeFilePath);
                byte[] fileData = db.AttachFiles.Where(w => w.Id == id).Select(s => s.Content).FirstOrDefault();// 读取 varbinary(max) 数据  

                File.WriteAllBytes(writeFilePath, fileData); // 将数据写入文件  
                Process.Start(readFilePath); // 打开文件（取决于文件类型） 


            }
        }

        #region clear the doawloaded files
        private void FrmUpload_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 获取目录信息
            DirectoryInfo dirInfo = new DirectoryInfo("temp");

            // 遍历目录中的所有文件和子目录
            foreach (FileInfo fileInfo in dirInfo.GetFiles())
            {
                try
                {
                    // 尝试删除文件
                    fileInfo.Delete();
                }
                catch (IOException) { } // 如果文件被占用，则忽略异常并继续下一个文件
                catch (UnauthorizedAccessException) { } // 如果没有权限访问文件，则忽略异常并继续下一个文件
            }

            
        }
    }


    #endregion

}
