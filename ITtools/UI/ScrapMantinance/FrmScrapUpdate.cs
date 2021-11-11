using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITtools.Model.Scrap;

namespace ITtools.UI.ScrapMantinance
{
    public partial class FrmScrapUpdate : Form
    {
        public FrmScrapUpdate()
        {
            InitializeComponent();
            txtVoucherNo.Enabled = false;
            
        }

        public WeighingSettlementModels m= new WeighingSettlementModels();


        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db=new ScrapContext())
                {
                    WeighingSettlementModels m = db.WeighingSettlementModels.Where(s => s.vocherNO == txtVoucherNo.Text).FirstOrDefault();

                    m.note = txtMemo.Text;

                    db.SaveChanges();

                    if (MessageBox.Show("修改成功！", "过磅单修改", MessageBoxButtons.OK, MessageBoxIcon.Information)
                       == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmScrapUpdate_Load(object sender, EventArgs e)
        {
            txtMemo.Text = m.note;
            txtVoucherNo.Text = m.vocherNO;
        }
    }
}
