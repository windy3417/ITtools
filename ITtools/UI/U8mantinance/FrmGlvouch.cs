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

namespace ITtools.UI.U8mantinance
{
    public partial class FrmGlvouch : Form
    {
        public FrmGlvouch()
        {
            InitializeComponent();
            this.FormClosed += closeParentForm;
        }

        private void closeParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(cmbYear.Text);
            int month= Convert.ToInt32(cmbMonth.Text);
            int vocherNo = Convert.ToInt32(txtNo.Text);
            try
            {
                using (var db=new U8Context())
                {
                    var q = from s in db.GL_accvouch.Where(s => s.iyear == year && s.iperiod == month
                            && s.ino_id == vocherNo)

                            join c in db.code.Where( c => c.iyear==year) on s.ccode equals c.ccode

                                                     



                            select new
                            {
                                会计年度 = s.iyear,
                                会计月份 = s.iperiod,
                                凭证号 = s.ino_id,
                                凭证行号 = s.inid,
                                摘要 = s.cdigest,
                                科目编码=s.ccode,
                                科目名称=c.ccode_name,
                                借方金额=s.md,
                                贷方金额=s.mc
                            };

                    dataGridView1.DataSource = q.ToList();
                    dataGridView1.AutoResizeColumn(4);

                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbModify_Click(object sender, EventArgs e)
        {
            FrmGlvouchModify  f = new FrmGlvouchModify();
            f.FormClosed += brushQuery;

            f.txtYear.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f.txtMonth.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f.txtVoucherNo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f.txtSN.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f.txtDigest.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f.txtAccountCode.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            f.txtAccountName.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();





            f.ShowDialog();
        }

        private void brushQuery(object sender, FormClosedEventArgs e)
        {
            this.tsbQuery.PerformClick();
        }
    }
}
