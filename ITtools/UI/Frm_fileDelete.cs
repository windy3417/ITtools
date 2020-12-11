using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft;
using Newtonsoft.Json;
using Utility.Files;
using ITtools.Services;
using ITtools.DAL;
using ITtools.Modle;

namespace ITtools.UI
{
    public partial class Frm_fileDelete
        : Form
    {

        #region 变量

        //删除文件计数
        int deleteFilesAmount;
        //文件删除完的标志
        bool finishedFlag;
        string directory;
        #endregion


        public Frm_fileDelete()

        {
            InitializeComponent();
            
            initializeControlsState();
            initializeControlDataSource();
            
        }

        void initializeControlsState()
        {
            this.FormClosed += new FormClosedEventHandler(closeParent);
            this.WindowState = FormWindowState.Maximized;
            progressBar1.Visible = false;
        }

        /// <summary>
        /// 初始化控件数据源
        /// </summary>
        void initializeControlDataSource()
        {
          
                                 
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeParent(object seder,System.Windows.Forms.FormClosedEventArgs formClosedEventArgs)
        {
            this.Parent.Dispose();
        }

        /// <summary>
        /// 打开指定文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_open_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                cmb_fileFolderDerectory.Text = folderBrowserDialog1.SelectedPath;
         
            } 

        }

        #region 删除垃圾文件过程

        /// <summary>
        /// 删除垃圾文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {

            //开启后台查询线程，即引发新线程的事件，同时提供事件参数
            //注意backgroundWork中的DoWork事件，并编写事件处理程序,
            //并提供事件数据，因为后台线程是无法直接访问主线程的数据的，
            //同时还需要编写backgroundWork中的RunWorkerCompleted事件处理程序，
            //以通知前端主线程

            string doWorkArguments = cmb_fileFolderDerectory.Text;
            backgroundWorker1.RunWorkerAsync(doWorkArguments);

            //开启处理进程条
            this.progressBar1.Visible = true;
            timer1.Interval = 100;
            this.timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Start();
            
            
        }

        /// <summary>
        /// 用计时器体现查询进度表，非真实进度，仅是对用户的提示，因后台查询进度暂无法计算衡量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (!finishedFlag)
            {
                if (progressBar1.Value == progressBar1.Maximum)
                {
                    progressBar1.Value = 1;
                }
                else
                {
                    this.progressBar1.Value++;
                }

            }
            else
            {
                this.timer1.Stop();

            }

        }

        /// <summary>
        /// 删除文件的后台进程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            FilesOperate f = new FilesOperate();
            int deleteFilesAmount = f.DeleteUserFile(e.Argument.ToString());

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

           this.finishedFlag = true;
            //完成后进程条不可见
            this.progressBar1.Visible = false;
            MessageBox.Show("删除垃圾文件" + this.deleteFilesAmount + "个", "删除提示");
        }

        #endregion


    }
}
