
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using ITtools.Modle;
using System.Collections.Generic;
using System.Configuration;
using Utility.Excel;
using Utility.UI;
using ITtools.Common;
using System.Collections;
using ITtools.DAL;
using ITtools.Services;

namespace ITtools.UI
{
    public partial class FrmResourcesList : Form
    {
        public FrmResourcesList()
        {
            
            InitializeComponent();
            this.initialize();
            initializeControlDataSource();

        }

        #region 变量
        //新增时,dataGridview绑定的数据源，以体现新增的结果
        List<WebURLModle> customerList = new List<WebURLModle>();
        //最大客户编号
        int maxCusCode;

        int resourceClass;

        //dataGridView控件的数据来源，true为查询时绑定，
        //false为新增档案时的绑定


        enum saveOrChangeOrQueryMolde
        {
            save,
            change,
            query
        }

        //修改与新增的dbContext标记,true为新增dbContext，false为修改dbContext

        //bool saveOrChangeFlag = true;
        string saveOrModifQueryFlag;

        #endregion

        #region 初始化控件

        /// <summary>
        /// 初始化控件状态
        /// </summary>
        private void initialize()
        {
            this.FormClosed += new FormClosedEventHandler(this.closeParent);



            this.dgv_list.AutoGenerateColumns = false;


            navigate.Width = 50;


        }

        /// <summary>
        /// 初始化控件数据源
        /// </summary>
        void initializeControlDataSource()
        {

            //不能直接绑定hashTable或dictinary因为会报以下错误
            //“复杂的 DataBinding 接受 IList 或 IListSource 作为数据源”
            cmb_class.DataSource = new BindingSource(new EnumService().GetITenum(), null);
            cmb_class.ValueMember = "key";
            cmb_class.DisplayMember = "value";


        }


        #endregion


        #region 菜单事件处理

        /// <summary>
        /// 以EXCEL格式，导出数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_export_Click(object sender, EventArgs e)
        {
            ExportExcel exprort = new ExportExcel();
            exprort.ExportExcelWithNPOI(dgv_list, "资源列表");
        }

        #region 查询



        /// <summary>
        /// 查询列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_query_Click(object sender, EventArgs e)
        {

            this.bind_gv_dateSource();


            if (dgv_list.Rows.Count > 0)
            {
                this.dgv_list.Rows[0].Selected = true;
            }


        }


        #endregion

        #endregion

         
        #region 内部方法
        /// <summary>
        /// 数据保存与修改
        /// </summary>
        private void saveOrChang()
        {

            if (inputVlidate())
            {
                //新增后保存
                if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.save.ToString())
                {
                    using (var db = new ItContext())
                    {

                        WebURLModle m = new WebURLModle();
                  
                        m.introduction = txt_content.Text;
                       
                        m.ResourceClass = (int)cmb_class.SelectedValue;


                        db.WebURLs.Add(m);
                        try
                        {
                            db.SaveChanges();
                        }
                        catch (Exception e)
                        {

                            MessageBox.Show("数据保存错误:" + e.Message + e.InnerException, "数据保存提示");
                            return;
                        }

                        customerList.Add(m);
                        //this.dataGridView1.DataSource = null;
                        //this.dataGridView1.DataSource = customerList;
                        //MessageBox.Show("数据保存成功", "保存提示");
                        this.bind_gv_dateSource();

                        //清空填制记录
                        //this.txt_cusCode.Text = null;
                        //this.txt_cusName.Text = null;
                        clearDate();

                        //再次调用新增事件

                    }
                }

                //查询之后修改并保存
                if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.query.ToString())
                {
                    using (var db = new ItContext())
                    {
                       

                                            

                       

                        db.SaveChanges();
                        this.bind_gv_dateSource();

                        //清空修改记录
                        clearDate();
                    }
                }
            };




        }

        /// <summary>
        /// 绑定dataGridView的数据源
        /// </summary>
        private void bind_gv_dateSource()
        {
                //dictionary也支持linq 查询
                var query = from q in new WebURLService().GetWebURLs()
                            join d in new EnumService().GetITenum().
                            Where(d =>d.Key==Convert.ToInt32(cmb_class.SelectedValue))
                            on q.ResourceClass equals d.Key
                            
                            select new { q.id, q.url, q.introduction, d.Value };



                this.dgv_list.DataSource = query.ToList();

         


        }

        /// <summary>
        /// 清除录入或查询出的数据
        /// </summary>
        private void clearDate()
        {
            foreach (Control item in this.tlp_record.Controls)
            {

                //if (item.Name.Substring(0, 3) != "lbl")
                if (item.GetType() != typeof(Label))
                {
                    item.Text = "";
                }



            }
        }

        #region 输入校验



        /// <summary>
        /// 为空校验
        /// </summary>
        private bool inputVlidate()
        {

            for (int i = 0; i < this.tlp_record.Controls.Count;)
            {

                if (this.tlp_record.Controls[i].Text == "" || this.tlp_record.Controls[i].Text == null)
                {
                    MessageBox.Show(this.tlp_record.Controls[i].Tag + "不能为空", "输入校验");
                    return false;
                }


                i++;


            }
            return true;


        }
        #endregion

        #endregion

        #region dataGridView数据处理与绑定
        /// <summary>
        /// 处理dataGridView中button列的单击事件,跳转到网页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
           dgv_list.Columns["navigate"].Index) return;
            NetHelper.OpenEdge(dgv_list.SelectedRows[0].Cells[3].Value.ToString());
        }


        /// <summary>
        /// 穿透查询到单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_list_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {

                int resourceID = Convert.ToInt32(dgv_list.Rows[e.RowIndex].Cells[0].Value);
                Frm_resources f = new Frm_resources();
                EmbedForm embedForm = new EmbedForm();

                embedForm.openForm(f, f.Text, (TabControl)this.Parent.Parent, (Panel)this.Parent.Parent.Parent);
                f.ResponThroughQuery(resourceID);
                f.tsb_modify.Enabled = true;
                f.saveOrModifQueryFlag = saveOrChangeOrQueryMolde.query.ToString();




            }
        }

      


        /// <summary>
        /// 选择当前行数据进行处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            clearDate();
            if (e.RowIndex > -1)
            {
              
                cmb_class.Text= dgv_list.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txt_content.Text = this.dgv_list.Rows[e.RowIndex].Cells[2].Value.ToString();
                
                
                
            }


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
        /// 查询功能快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_resourceList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q && e.Control)
            {
                tsb_contentSerch.PerformClick(); //执行单击button1的动作      
            }
          
            
        }












        #endregion

        #endregion

        /// <summary>
        /// 内容模糊查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_contentSerch_Click(object sender, EventArgs e)
        {
            var query = from q in new WebURLService().GetWebURLs().
                        //toLower后比较时可忽略大小写，因为是都转为小写后比较的
                Where(s => s.introduction.ToLower().Contains(this.txt_content.Text.ToLower()))
                        join d in new EnumService().GetITenum()
                        
                        on q.ResourceClass equals d.Key

                        select new { q.id, q.url, q.introduction, d.Value };
                        
            this.dgv_list.DataSource = query.ToList();

            
        }
    }
}