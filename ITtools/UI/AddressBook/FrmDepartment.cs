using ITtools.Model;
using ITtools.Model.DAL.Services;
using ITtools.Model.IT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.DAL;
using Utility.Sql;

namespace ITtools.UI.AddressBook
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
            this.FormClosed += CloseParentForm;
        }

        private void CloseParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        #region varialbes
        //dylamic save button
        ToolStripButton tsbSaveForChange=new ToolStripButton();


        #endregion

        private void TsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region crud

        private void TsbQuery_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Utility.DAL.QueryService.GetDataList<Department>(Sqlhelper.DataSourceType.it);
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Utility.DAL.SaveService saveService = new Utility.DAL.SaveService();
            Department m = new Department();
            m.deptID = txtDepartmentCode.Text;
            m.deptName = txtDepartmentName.Text;
            m.EnglishName = txtDepartmentEnglishName.Text;
            
            saveService.SaveSingleRowDate<Department, ItContext>(m);
        }

        /// <summary>
        /// save data after change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveForChang(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Department m = new Department();
            m.deptName = txtDepartmentName.Text;
            m.EnglishName = txtDepartmentEnglishName.Text;

            Expression<Func<Department, bool>> expression = s => s.deptID == this.txtDepartmentCode.Text;

            new UpdateService().Update<Department, ItContext>
            (expression, m);
            this.Cursor = Cursors.Default;

            tsbSave.Visible = true;
            tsbSave.Enabled = false;
            tsbSaveForChange.Visible = false;
            TsbQuery.PerformClick();
        }



        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            this.tsbSave.Visible = false;


            var i = toolStrip1.Items.IndexOf(tsbSave);
          
            tsbSaveForChange.Visible = true;   
            tsbSaveForChange.Text = "保存";
            tsbSaveForChange.Image = Properties.Resources.save;
            toolStrip1.Items.Insert(i, tsbSaveForChange);

            tsbSaveForChange.Click += SaveForChang;


            Int32 selectedRowCount =
             dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

              
                   this.txtDepartmentCode.Text=dataGridView1.SelectedRows[0].Cells["deptID"].Value.ToString();
                            
            }

            SqlParameter[] ps = { new SqlParameter("@deptID", txtDepartmentCode.Text) };

            Department m = QueryService.GetEntity<Department>(ps, Sqlhelper.DataSourceType.it);

            this.txtDepartmentName.Text = m.deptName;
            this.txtDepartmentEnglishName.Text = m.EnglishName;
            
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            
            Int32 selectedRowCount =
             dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                this.Cursor = Cursors.WaitCursor;
                this.txtDepartmentCode.Text = dataGridView1.SelectedRows[0].Cells["deptID"].Value.ToString();

                Expression<Func<Department, bool>> expression = s => s.deptID == this.txtDepartmentCode.Text;
                DeleteService d = new DeleteService();
                d.DeletSingleRow<Department, ItContext>(dataGridView1, expression);

                this.Cursor = Cursors.Default;

            }
         
        }

        #endregion

        #region style


        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.StyleDataGridView styleDataGridView = new Utility.Style.StyleDataGridView();
            styleDataGridView.DisplayRowNo(e, dataGridView1);
        }

        #endregion

      
    }
}
