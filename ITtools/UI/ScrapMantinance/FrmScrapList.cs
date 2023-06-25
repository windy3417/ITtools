using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITtools.Model.Scrap;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;

namespace ITtools.UI.ScrapMantinance
{
    public partial class FrmScrapList : Form
    {
        public FrmScrapList()
        {
            InitializeComponent();
            this.FormClosed += CloseParentForm;
        }

        private void CloseParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            //动态查询表达式树
            Expression<Func<WeighingSettlement, bool>> expr =
                n => GetCondition(n, dtpStartDate.Value.Date, dtpEndDate.Value.Date//必须取日期，否则做比较时会加入当前查询时间，而不准确
              );

            try
            {
                using (var db=new ScrapContext())
                {

                    db.Database.Log = s =>
                    {
                        using (StreamWriter sw = File.CreateText(Environment.CurrentDirectory + "\\test.txt"))
                        {
                            //File.AppendAllLines(Environment.CurrentDirectory + "\\test.txt", System.Text.Encoding.Default.GetBytes(s));
                            sw.WriteLine(s);
                            //sw.Write(System.Text.Encoding.Default.GetBytes(s), 0, Encoding.Default.GetByteCount(s));

                        }


                    };
                    db.Database.Log = Console.Write;
                    var q = from s in db.WeighingSettlement.Where(expr.Compile())
                            select s;
                   
                    dataGridView1.DataSource = q.ToList();

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

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                FrmScrapUpdate f = new FrmScrapUpdate();
                f.m.vocherNO = dataGridView1.CurrentRow.Cells["vocherNo"].Value.ToString();
                f.m.note = dataGridView1.CurrentRow.Cells["note"].Value.ToString();
                f.m.netWeight=Convert.ToDouble( dataGridView1.CurrentRow.Cells["netWeight"].Value);
                f.m.Tare= Convert.ToDouble(dataGridView1.CurrentRow.Cells["Tare"].Value);

                f.Show();

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }

        #region 内部方法


        /// <summary>
        /// Linq动态查询参数
        /// </summary>
        /// <param name="m"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        private bool GetCondition(WeighingSettlement m, DateTime startDate, DateTime endDate)
           
        {
            bool boolResult = true;
            if (!String.IsNullOrEmpty(startDate.ToString()))
            {
                boolResult &= m.WeighingDate >= startDate;
            }
            if (!String.IsNullOrEmpty(endDate.ToString()))
            {
                boolResult &= m.WeighingDate <= endDate;
            }

           
            return boolResult;
        }

        #endregion

        private void tsbExport_Click(object sender, EventArgs e)
        {
            Utility.Excel.ExportExcel exportExcel = new Utility.Excel.ExportExcel();
            exportExcel.ExportExcelWithNPOI(this.dataGridView1, "过磅单列表");
        }
    }
}
