using ITtools.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.Validate;
using ITtools.Model;

namespace ITtools.UI
{
    public partial class FrmDirectory : Form
    {
        public FrmDirectory()
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

        #region 菜单事件处理

        /// <summary>
        /// 单据保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_save_Click(object sender, EventArgs e)
        {
            Validate validate = new Validate();
            if (validate.inputVlidate(tableLayoutPanel1))
            {
                using (var db = new ItContext())
                {
                    DiretoryModle m = new DiretoryModle();
                    m.directoryID = txt_dierctoryID.Text;
                    m.diretory = txt_directory.Text;
                    m.directoryType = cbType.Text;
                    db.Diretory.Add(m);
                    db.SaveChanges();
                    MessageBox.Show("数据保存成功！", "保存提示");
                }
            }
        }

        /// <summary>
        /// 单据列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_query_Click(object sender, EventArgs e)
        {
            using (var db = new ItContext())
            {
                var query = db.Diretory.ToList();
                dgv_list.DataSource = query;
            }
        }

        #endregion


    }
}
