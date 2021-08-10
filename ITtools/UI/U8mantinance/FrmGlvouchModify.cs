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
using ITtools.Model.U8;

namespace ITtools.UI.U8mantinance
{
    public partial class FrmGlvouchModify : Form
    {
        public FrmGlvouchModify()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            int iyear = Convert.ToInt32(txtYear.Text);
            int iperiod = Convert.ToInt32(txtMonth.Text);
            int voucherNo = Convert.ToInt32(txtVoucherNo.Text);
            int inid = Convert.ToInt32(txtSN.Text);

            try
            {
                using (var db = new U8Context())
                {
                    GL_accvouch m = db.GL_accvouch.Where(s => s.iyear == iyear && s.iperiod == iperiod 
                        && s.ino_id== voucherNo && s.inid == inid).FirstOrDefault();

                    m.cdigest = txtDigest.Text;
                    db.SaveChanges();

                    if (MessageBox.Show("摘要修改成功！", "凭证摘要修改", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ==DialogResult.OK)
                    {
                        this.Close();
                    }  


                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
            
        }
    }
}
