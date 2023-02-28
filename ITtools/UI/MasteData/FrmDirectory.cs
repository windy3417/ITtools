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
using ITtools.Model.IT;

namespace ITtools.UI
{
    public partial class FrmDirectory : Form
    {
        public FrmDirectory()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(this.closeParent);
          
        }

        #region 变量

        string addOrUpdate;
        #endregion

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
            
            if (Utility.Validate.Validate.inputVlidate(tableLayoutPanel1))
            {

                if (addOrUpdate=="add")
                {
                    using (var db = new ItContext())
                    {
                        Directory m = new Directory();
                        m.directoryID = txt_dierctoryID.Text;
                        m.diretory = txt_directory.Text;
                        m.directoryType = cmbClass.Text;
                        db.Directory.Add(m);
                        db.SaveChanges();
                        MessageBox.Show("数据保存成功！", "保存提示");
                    }
                }

                if (addOrUpdate=="update")
                {
                    using (var db=new ItContext())
                    {
                        Directory m = db.Directory.Where(s => s.directoryID == txt_dierctoryID.Text).FirstOrDefault();
                    
                        m.diretory = txt_directory.Text;
                        m.directoryType = cmbClass.Text;

                        db.SaveChanges();

                        MessageBox.Show("数据修改成功");

                    }
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
                var query = db.Directory.ToList();
                dgv_list.DataSource = query;


                dgv_list.AutoResizeColumns();
            }
        }


        #endregion

        private void tsbModify_Click(object sender, EventArgs e)
        {
            if (dgv_list.CurrentRow !=null)
            {
                addOrUpdate = "update";
                txt_dierctoryID.Enabled = false;
                
                txt_dierctoryID.Text = dgv_list.CurrentRow.Cells[0].Value.ToString();
                txt_directory.Text = dgv_list.CurrentRow.Cells[2].Value.ToString();
                cmbClass.Text= dgv_list.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void tsb_add_Click(object sender, EventArgs e)
        {
            addOrUpdate = "add";
            txt_dierctoryID.Enabled = true;
        }
    }
}
