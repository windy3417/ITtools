
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
using ITtools.Common;
using System.Collections;
using ITtools.DAL;
using ITtools.Services;
using ITtools.Model.IT;
using static ITtools.Model.EnumModle;
using ITtools.UI.RefForm;
using ITtools.DAL.Services;
using ITtools.DAL.VModel;

namespace ITtools.UI
{
    public partial class FrmWeakCurrence : Form
    {
        public FrmWeakCurrence()
        {
            InitializeComponent();
            this.initialize();
          

        }

        #region 变量
        //新增时,dataGridview绑定的数据源，以体现新增的结果
        List<PrWeakCurrentModel> mList = new List<PrWeakCurrentModel>();
      


        //修改与新增的dbContext标记,true为新增dbContext，false为修改dbContext

        //bool saveOrChangeFlag = true;
        public string saveOrModifQueryFlag=saveOrChangeOrQueryMolde.save.ToString();

        #endregion


        /// <summary>
        /// 初始化控件状态
        /// </summary>
        private void initialize()
        {
            this.FormClosed += new FormClosedEventHandler(this.closeParent);
       
      


        }


       
        #region 菜单事件处理
        /// <summary>
        /// 放弃新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_abandon_Click(object sender, EventArgs e)
        {
            tsb_save.Enabled = false;
            tsb_modify.Enabled = false;
            tsb_delete.Enabled = false;
            tsb_query.Enabled = true;
    
            tsb_abandon.Enabled = false;
            clearDate();
        

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
                string selected =dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (DialogResult.Yes == MessageBox.Show("是否确定删除", "删除提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {

                    var db = new ItContext();

                    List<PrWeakCurrentModel> d = (from del in db.PrWeakCurrent
                                           where del.PrVoucherNo == selected
                                           select del).ToList<PrWeakCurrentModel>();
                    //移除数据库的数据
                    db.PrWeakCurrent
                        .Remove(d[0]);
                    db.SaveChanges();
                    clearDate();

                    //如果是在新增界面状态使用删除功能，则同时删除内存中的集合数据
                    //数据库中的条件实体delCustomer不能成为内存中的待删除实体
                    //即：customerList.Remove(delCustomer[0])返回false,故无法实现
                    //内存当中的数据集记录删除;
                    if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.save.ToString())
                    {

                        List<PrWeakCurrentModel> m = mList.Where(c => c.PrVoucherNo == selected).ToList<PrWeakCurrentModel>();
                        mList.Remove(m[0]);

                    }
                    bind_gv_dateSource();
                }
            }

            return;

        }

        /// <summary>
        /// 保存客户档案
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
            if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.query.ToString())
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
     

            tsb_save.Enabled = true;

        }

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

            saveOrModifQueryFlag = saveOrChangeOrQueryMolde.query.ToString();
            this.tsb_save.Enabled = false;
            this.tsb_modify.Enabled = true;
            this.tsb_delete.Enabled = true;

            this.bind_gv_dateSource();


         


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

        #region 内部方法
 
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
                    this.tsb_save.Enabled = false;
                }
                catch (Exception e)
                {

                    MessageBox.Show("数据保存错误:" + e.Message + e.InnerException, "数据保存提示");
                    return;
                }

                //提供dataGridView的数据源
                mList.Add(m);

                this.bind_gv_dateSource();

                //清空填制记录

                clearDate();




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
                    this.bind_gv_dateSource();

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
     

        /// <summary>
        /// 绑定dataGridView的数据源
        /// </summary>
        private void bind_gv_dateSource()
        {
            this.dataGridView1.DataSource = null;


            this.dataGridView1.DataSource = new ProjectSettleService().getProject();

          


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
                tsb_save.PerformClick(); //执行单击button1的动作      
            }
            if (e.KeyCode == Keys.Delete)
            {
                tsb_delete.PerformClick();
            }

        }













        #endregion

        #endregion

        private void tsbRef_Click(object sender, EventArgs e)
        {
            FrmAppPurRef f = new FrmAppPurRef();
            f.Show();
            //f.transferData(transferData);
            f.actionAppVoucher = transferData;

            tsb_save.Enabled = true;
            
            
        }

        void transferData(AppPurVmodel refAppPur)
        {
          
            txtPrVoucherNo.Text = refAppPur.cCode;
            txtPrContent.Text = refAppPur.cInvCode + " " + refAppPur.cInvName + " " + refAppPur.cInvStd;
            txbPrPerson.Text = refAppPur.cPersonName;
            dtpPrDate.Value =Convert.ToDateTime( refAppPur.dDate);
           
            

            
        }
    }
}