using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U8services.Model;
using Utility.DAL;

namespace ITtools.UI.U8mantinance
{
    public partial class FrmAuditFlowModify : Form
    {
        public FrmAuditFlowModify()
        {
            InitializeComponent();
            InitialControlData();
           
        }

        void InitialControlData()
        {
            cmbOperationType.SelectedIndex = 0;
            cmbVoucherType.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (Utility.Validate.Validate.inputVlidate(panInput))
                {
                    if (DialogResult.OK == MessageBox.Show("是否确认修改", "修改确认", MessageBoxButtons.OKCancel))
                    {
                        this.Cursor = Cursors.WaitCursor;

                        #region corect po
                        if (cmbVoucherType.Text == "采购订单")
                        {
                            if (cmbOperationType.Text == "未提交")
                            {


                                using (U8Context db = new U8Context())
                                {
                                    PO_Pomain m = db.PO_Pomain.Where(w => w.cPOID == txtVoucherNo.Text).FirstOrDefault();
                                    m.iverifystateex = 0;
                                    db.SaveChanges();

                                }

                                this.Cursor = Cursors.Default;
                            }

                            if (cmbOperationType.Text == "已提交")
                            {

                                this.Cursor = Cursors.WaitCursor;
                                using (U8Context db = new U8Context())
                                {
                                    PO_Pomain m = db.PO_Pomain.Where(w => w.cPOID == txtVoucherNo.Text).FirstOrDefault();
                                    m.iverifystateex = 1;
                                    db.SaveChanges();

                                }


                            }
                        }
                        #endregion

                        #region corect PU_PriceJustVoucher
                        if (cmbVoucherType.Text == "供应商存货调价单")
                        {
                            if (cmbOperationType.Text == "未提交")
                            {


                                using (U8Context db = new U8Context())
                                {
                                    PU_PriceJustMain m = db.PU_PriceJustMain.Where(w => w.ccode == txtVoucherNo.Text).FirstOrDefault();
                                    m.iverifystate = 0;
                                    db.SaveChanges();

                                }

                                this.Cursor = Cursors.Default;
                            }

                            if (cmbOperationType.Text == "已提交")
                            {

                                this.Cursor = Cursors.WaitCursor;
                                using (U8Context db = new U8Context())
                                {
                                    PU_PriceJustMain m = db.PU_PriceJustMain.Where(w => w.ccode == txtVoucherNo.Text).FirstOrDefault();
                                    m.iverifystate = 1;
                                    db.SaveChanges();

                                }


                            }
                        }
                        #endregion


                        MessageBox.Show("数据修改成功！");

                        this.Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
          
            
        }
    }
}
