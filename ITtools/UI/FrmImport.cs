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
    public partial class FrmImport : Form
    {
        public FrmImport()
        {
            InitializeComponent();
            this.Load += FrmImport_Load;
            this.FormClosed += closeParentForm;
            this.DgvImport.RowPostPaint += displayRowNo;
        }

        private void displayRowNo(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.StyleDataGridView styleDataGridView = new Utility.Style.StyleDataGridView();
            styleDataGridView.DisplayRowNo(e, this.DgvImport);
        }

        private void closeParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void FrmImport_Load(object sender, EventArgs e)
        {
            dataBinding();
        }

        #region 变量

        DataTable dt = new DataTable();
        #endregion

        private void tsmChooseFile_Click(object sender, EventArgs e)
        {
            Utility.Files.ImportFromExcel importFromExcel = new Utility.Files.ImportFromExcel();
            //importFromExcel.OpenExcelFile();
            importFromExcel.ImportFileFromExcel(DgvImport, dt);
        }

        void dataBinding()
        {
            using (var db = new ItContext())
            {
                var query = from s in db.MaxKeys
                            select s.VoucherName;
                cmbFileName.DataSource = query.ToArray();
            }
        }

        private void TsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsbSave_Click(object sender, EventArgs e)
        {
            this.saveData(this.cmbFileName.Text);
        }

        void saveData(string tableName)
        {
            var itdb = new ItContext();
            int maxID = 1000000;

            try
            {
                using (var db = new U8Context())
                {

                    switch (tableName)
                    {
                        case "预算项目":
                            //待变更实体
                            var maxIDBudgetItem = itdb.MaxKeys.Where(s => s.VoucherName == "预算项目").FirstOrDefault();
                            maxID = maxIDBudgetItem.CurrentKeyValue;
                            for (int i = 0; i < DgvImport.Rows.Count - 1; i++)
                            {
                                U8CUSTDEF_0044_E002 budgetItem = new U8CUSTDEF_0044_E002();

                                budgetItem.cNo = DgvImport.Rows[i].Cells[0].Value.ToString();
                                budgetItem.cCardName = DgvImport.Rows[i].Cells[1].Value.ToString();
                                budgetItem.cMaker = "demo";
                                budgetItem.cMender = "demo";
                                budgetItem.dMakeDate = DateTime.Now;
                                budgetItem.dMakeDateEx = DateTime.Now;
                                budgetItem.U8CUSTDEF_0043_E001_PK = 2;
                                budgetItem.UAPRuntime_RowNO = i + 1;

                                budgetItem.U8CUSTDEF_0044_E002_PK = maxID + i;

                                db.U8CUSTDEF_0044_E002.Add(budgetItem);
                                maxIDBudgetItem.CurrentKeyValue = maxID + i;

                            }
                            break;

                        case "科目预算对照":
                            //待变更实体
                            var maxIDCodeContrast = itdb.MaxKeys.Where(s => s.VoucherName == "科目预算对照").FirstOrDefault();
                            maxID = maxIDCodeContrast.CurrentKeyValue;
                            for (int i = 0; i < DgvImport.Rows.Count - 1; i++)
                            {
                                U8CUSTDEF_0061_E002 codeContrasst = new U8CUSTDEF_0061_E002();

                                codeContrasst.U8CUSTDEF_0061_E002_F000 = DgvImport.Rows[i].Cells[0].Value.ToString();
                                codeContrasst.U8CUSTDEF_0061_E002_F002 = DgvImport.Rows[i].Cells[2].Value.ToString();

                                codeContrasst.U8CUSTDEF_0061_E001_PK = 1;
                                codeContrasst.UAPRuntime_RowNO = i + 1;

                                codeContrasst.U8CUSTDEF_0061_E002_PK = maxID + i;

                                db.U8CUSTDEF_0061_E002.Add(codeContrasst);
                                maxIDCodeContrast.CurrentKeyValue = maxID + i;

                            }
                            break;
                        default:
                            break;
                    }



                    db.SaveChanges();
                    //存储最大ID号
                    itdb.SaveChanges();

                    MessageBox.Show("数据保存成功！");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }

        }
    }
}
