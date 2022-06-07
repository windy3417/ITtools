
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using ITtools.Model;
using System.Collections.Generic;
using System.Configuration;
using Utility;
using Utility.UI.Authority;
using ITtools.Common;
using System.Collections;
using ITtools.DAL;
using ITtools.Services;
using ITtools.Model.IT;
using static ITtools.Model.EnumModle;
using ITtools.UI.RefForm;
using ITtools.DAL.Services;
using ITtools.DAL.VModel;
using ITtools.UI.MasteData;
using ITtools.UI.FilterForm;

namespace ITtools.UI
{
    public partial class FrmWeakCurrence : Form
    {
        public FrmWeakCurrence()
        {
            InitializeComponent();
            this.InitializeControlsState();


        }

        #region 变量
        //新增时,dataGridview绑定的数据源，以体现新增的结果
        List<PrWeakCurrentModel> mList = new List<PrWeakCurrentModel>();



        //修改与新增的dbContext标记,true为新增dbContext，false为修改dbContext

        //bool saveOrChangeFlag = true;
        public string saveOrModifQueryFlag = saveOrChangeOrQueryMolde.save.ToString();

        #endregion

          


        #region 菜单事件处理
        /// <summary>
        /// 放弃新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_abandon_Click(object sender, EventArgs e)
        {
            tsbSave.Enabled = false;
            tsb_modify.Enabled = false;
            tsb_delete.Enabled = false;
            tsb_query.Enabled = true;

            clearDate();


        }


        private void tsbExport_Click(object sender, EventArgs e)
        {
            Utility.Excel.ExportExcel exportExcel = new Utility.Excel.ExportExcel();
            exportExcel.ExportExcelWithNPOI(dataGridView1, "未验收结算弱电工程项目清单");


        }

        private void tsbRef_Click(object sender, EventArgs e)
        {
            FrmAppPurRef f = new FrmAppPurRef();
            f.Show();
            //f.transferData(transferData);
            f.actionAppVoucher = transferData;

            tsbSave.Enabled = true;


        }

        #region 增删改查




        /// <summary>
        /// 删除选择定行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_delete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                string selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();


                var db = new ItContext();

                List<PrWeakCurrentModel> d = (from del in db.PrWeakCurrent
                                              where del.PrVoucherNo == selected
                                              select del).ToList<PrWeakCurrentModel>();
                if (d[0].isSettle is null || (bool)d[0].isSettle ==false)
                {
                    if (DialogResult.Yes == MessageBox.Show("是否确定删除", "删除提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        //移除数据库的数据
                        db.PrWeakCurrent
                            .Remove(d[0]);
                        db.SaveChanges();
                        clearDate();

                    }
                }

                else
                {
                    MessageBox.Show("您当前选择的单据已经结算，不能删除!");
                    return;
                }



               

            }

            return;

        }

        /// <summary>
        /// 保存工程项目信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_save_Click(object sender, EventArgs e)
        {

            //新增后保存
            if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.save.ToString())
            {
                save();
            }


            //修改数据
            if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.change.ToString())
            {
                update();
            }

        }



        /// <summary>
        /// 修改资源信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_modify_Click(object sender, EventArgs e)
        {
            lbl_voucherStatus.Text = "档案状态：修改";
            lbl_voucherStatus.Visible = true;


            tsbSave.Enabled = true;

        }


       



        #endregion

        #endregion

        #region 输入校验

        /// <summary>
        /// 正则校验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void regValidating(object sender, CancelEventArgs e)
        {
            string pattern = "^-?[1-9]\\d*$";
            Regex regex = new Regex(pattern);


        }


        #endregion

        #region crud

        #region get data

        /// <summary>
        /// 查询档案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_query_Click(object sender, EventArgs e)
        {
            clearDate();
            lbl_voucherStatus.Text = "状态：查询";
            lbl_voucherStatus.Visible = true;


            this.tsbSave.Enabled = false;
            this.tsb_modify.Enabled = true;
            this.tsb_delete.Enabled = true;

            FrmFilterWeakCurrent f = new FrmFilterWeakCurrent();
            f.ActionListProject = bind_gv_dateSource;
            f.StartPosition = FormStartPosition.CenterScreen;
            
            f.ShowDialog();
           
            



        }

        /// <summary>
        /// 绑定dataGridView的数据源
        /// </summary>
        private void bind_gv_dateSource(List<ProjectSettleVmodel> list)
        {
            this.dataGridView1.DataSource = null;

            this.dataGridView1.DataSource = list;
            dataGridView1.AutoResizeColumns();

         

        }


        #endregion

        /// <summary>
        /// 新增数据
        /// </summary>
        void save()
        {
            using (var db = new ItContext())
            {

                PrWeakCurrentModel m = new PrWeakCurrentModel();


                m.projectContent = txtPrContent.Text;
                m.PrDate = dtpPrDate.Value;
                m.PrPerson = txbPrPerson.Text;
                m.PrVoucherNo = txtPrVoucherNo.Text;

                db.PrWeakCurrent.Add(m);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("save success");
                    this.tsbSave.Enabled = false;
                }
                catch (Exception e)
                {

                    MessageBox.Show("数据保存错误:" + e.Message + e.InnerException, "数据保存提示");
                    return;
                }

                //提供dataGridView的数据源
                mList.Add(m);

                this.tsbSave.Enabled = false;

                //清空填制记录

                clearDate();




            }
        }

        /// <summary>
        /// 撤销验收
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Oppsite(object sender, AuthorizationEventArgs e)
        {
            if (e.userAndPwdRight)
            {
                using (var db = new ItContext())
                {
                    string ccode = dataGridView1.CurrentRow.Cells["ccode"].Value.ToString();
                    PrWeakCurrentModel m = db.PrWeakCurrent.Where(s => s.PrVoucherNo == ccode).FirstOrDefault();
                    m.isSettle = false;
                    m.settleDate = null;

                    db.SaveChanges();
                    MessageBox.Show("撤销验收成功！");

                 
                }
            }
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        private void update()
        {

            using (var db = new ItContext())
            {
                PrWeakCurrentModel m = db.PrWeakCurrent.Where(c => c.PrVoucherNo.ToString() == txtPrVoucherNo.Text).FirstOrDefault();



                m.projectContent = txtPrContent.Text;
                m.PrDate = dtpPrDate.Value;
                m.PrPerson = txbPrPerson.Text;

                db.SaveChanges();
              

                //清空修改记录
                clearDate();
            }


        }




        #endregion

        #region 供外部调用方法

        /// <summary>
        /// 响应列表的穿透查询
        /// </summary>
        /// <param name="resourceID"></param>
        public void ResponThroughQuery(int resourceID)
        {
            var query = from q in new WebURLService().GetWebURLs().Where(q => q.id == resourceID)
                        join d in new EnumService().GetITenum() on q.ResourceClass equals d.Key
                        select new { q.id, q.url, q.introduction, d.Value };






        }

        #endregion

        #region dataGridView数据处理与绑定

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.StyleDataGridView style = new Utility.Style.StyleDataGridView();
            style.DataGridViewColumnHeaderStyle(dataGridView1);
            style.DisplayRowNo(e, dataGridView1);
        }

        private void tsbSettle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    string selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();


                    var db = new ItContext();

                    PrWeakCurrentModel m = db.PrWeakCurrent.Where(s => s.PrVoucherNo == selected).FirstOrDefault();

                    if (m.isSettle is true)
                    {
                        MessageBox.Show("您所选择的项目已经验收，不能两次验收！", "验收提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    m.isSettle = true;
                    m.settleDate = DateTime.Now.Date;

                    db.SaveChanges();

                    MessageBox.Show("您所选择的项目已经验收完成");
                  


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("请选择所要验收的行"+ex.Message + ex.InnerException);
            }
        }

        /// <summary>
        /// 附件查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.ColumnIndex ==
          dataGridView1.Columns["attachment"].Index)
            {
                FrmUpload f = new FrmUpload();
                f.ShowDialog();
            }

            else
            {
                return;

            }

        }

      

        /// <summary>
        /// 清除录入或查询出的数据
        /// </summary>
        private void clearDate()
        {

        }



        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            tsb_delete.Enabled = true;
        }

        #endregion


        #region 主窗体事件处理

        #region 窗体操作
        /// <summary>
        /// 关闭嵌入式窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /// <summary>
        /// 关闭母窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeParent(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }


        private void FrmWeakCurrence_Shown(object sender, EventArgs e)
        {
            //请购内容框的右边距
            //txtPrContent.Width = this.tbdSettleDate.Location.X - txtPrContent.Location.X + this.tbdSettleDate.Width;
        }

        #endregion

        #region 快捷键
        /// <summary>
        /// 回车代替TAB键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Convert.ToInt32(e.KeyChar) == 13)
            {
                System.Windows.Forms.SendKeys.Send("{tab}");
            }
        }

        /// <summary>
        /// 删除\保存功能快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_customer_KeyDown(object sender, KeyEventArgs e)
        {
            // if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            if (e.KeyCode == Keys.S && e.Control)
            {
                tsbSave.PerformClick(); //执行单击button1的动作      
            }
            if (e.KeyCode == Keys.Delete)
            {
                tsb_delete.PerformClick();
            }

        }













        #endregion

        #endregion

        #region style
        /// <summary>
        /// 初始化控件状态
        /// </summary>
        private void InitializeControlsState()
        {
            this.FormClosed += new FormClosedEventHandler(this.closeParent);
            dataGridView1.AutoGenerateColumns = false;


        }

        #endregion

      

        void transferData(AppPurVmodel refAppPur)
        {

            txtPrVoucherNo.Text = refAppPur.cCode;
            txtPrContent.Text = refAppPur.cInvCode + " " + refAppPur.cInvName + " " + refAppPur.cInvStd;
            txbPrPerson.Text = refAppPur.cPersonName;
            dtpPrDate.Value = Convert.ToDateTime(refAppPur.dDate);




        }


        private void tsbCancel_Click(object sender, EventArgs e)
        {

            if ((bool)dataGridView1.CurrentRow.Cells["settleFfag"].Value!=true)
            {
                MessageBox.Show("你所要撤销的项目还未验收");
                return;

            }

            else
            {
                FrmAuthorization f = new FrmAuthorization();
                f.authorizPass += Oppsite;
                f.ShowDialog();
            }
           
        }

        
        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.Automatic;
        }
    }
}