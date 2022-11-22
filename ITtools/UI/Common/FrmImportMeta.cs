using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITtools.Model;

namespace ITtools.UI
{
    public partial class FrmImportMeta : Form
    {
        public FrmImportMeta()
        {
            InitializeComponent();
            this.FormClosed += closeParentForm;
            
        }

        private void closeParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void TsbSave_Click(object sender, EventArgs e)
        {
            using (var db=new ItContext())
            {
                try
                {
                    MaxKeyModel m = new MaxKeyModel();
                    m.VoucherCode = System.Convert.ToInt32(this.txtVoucherCode.Text);
                    m.VoucherName = this.txtVoucherName.Text;
                    m.CurrentKeyValue = Convert.ToInt32(this.txtMaxID.Text);
                    db.MaxKeys.Add(m);
                    db.SaveChanges();
                    MessageBox.Show("保存成功！");
                    this.dataBinding();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ex.InnerException);
                }
             
            }
        }

        void dataBinding()
        {
            using (var db=new ItContext())
            {
                var query = from s in db.MaxKeys
                            select new
                            {
                                单据编码 = s.VoucherCode,
                                单据名称 = s.VoucherName,
                                当前单据ID = s.CurrentKeyValue

                            };
                DgvList.DataSource = query.ToList();
                this.DgvList.AutoResizeColumn(1);
            }
        }

        private void TsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            this.dataBinding();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new ItContext())
                {
                    int currentID = Convert.ToInt32(this.DgvList.CurrentRow.Cells[0].Value);
                    var m = db.MaxKeys.Where(s => s.id ==currentID ).FirstOrDefault();
                    db.MaxKeys.Remove(m);
                    db.SaveChanges();
                    MessageBox.Show("数据删除成功！");
                    this.dataBinding();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
            
           
        }
    }
}
