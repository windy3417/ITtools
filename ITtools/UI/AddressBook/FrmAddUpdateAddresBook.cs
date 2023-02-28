using ITtools.DAL;
using ITtools.DAL.Services.AddressBook;
using ITtools.Model;
using ITtools.Model.DAL.Services;
using ITtools.Model.IT;
using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.DAL;
using Utility.Sql;
using System.Data.SqlClient;

namespace ITtools.UI.AddressBook
{
    public partial class FrmAddUpdateAddresBook : Form
    {
        public FrmAddUpdateAddresBook()
        {
            InitializeComponent();
            this.FormClosed += CloseParentForm;
             InitialContolsData();
        }

      
       void InitialContolsData()
        {
            CmbDept.DataSource = new DepartmentService().GetDepanrtmentList();

            CmbDept.DisplayMember = "deptName";
            CmbDept.ValueMember = "deptId";
        }

        #region crud

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            TsbSave.Enabled = true;
            foreach (var item in this.Controls)
            {
                var t = item.GetType();

                if (item.GetType().Name == "TextBox")
                {
                    item.GetType().GetProperty("Text").SetValue(item, "");
                }
            }
        }


        private void TsbSave_Click(object sender, EventArgs e)
        {
            addressBook m = new addressBook();

            m.chinessName = TxtName.Text;
            m.deptID = CmbDept.SelectedValue.ToString();
            m.Ext = TxtExt.Text == "" ? (Nullable<double>)null : Convert.ToDouble(TxtExt.Text);
            m.emailAddress = TxtEmail.Text;
            m.memoryCode = TinyPinyin.Core.PinyinHelper.GetPinyinInitials(TxtName.Text);

            Utility.DAL.SaveService saveService = new Utility.DAL.SaveService();
            saveService.SaveSingleRowDate<addressBook, ItContext>(m);

            TsbSave.Enabled = false;

        }



        #endregion

        #region style and form

        private void CloseParentForm(object sender, FormClosedEventArgs e)
        {

            if (this.Parent!=null)
            {
                this.Parent.Dispose();
            }
           
        }

        private void TsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region update data

        //Row number of the data to be modified
        int id;
        
        /// <summary>
        /// called by main form
        /// </summary>
        /// <param name="id"></param>
      public  void update(int id)
        {
            this.TsbSave.Visible = false;
            this.id = id;
            ToolStripButton btnUpdate = new ToolStripButton();
            btnUpdate.Text = "保存";
            btnUpdate.Image = Properties.Resources.save;

            toolStrip1.Items.Insert(toolStrip1.Items.IndexOf(TsbSave), btnUpdate);

            btnUpdate.Click += SaveAfterChange;

            SqlParameter[] ps = { new SqlParameter("@id", id) };
            
            addressBook m=  QueryService.GetEntity<addressBook>(ps, Sqlhelper.DataSourceType.it);

            this.txtDepartmentEnglishName.Text= m.engDepartment;
            this.TxtEmail.Text = m.emailAddress;
            this.TxtEnglishName.Text = m.englishName;
            this.TxtName.Text = m.chinessName;
            this.TxtExt.Text = m.Ext.ToString();
            this.TxtTel.Text = m.mobilePhoneNumber.ToString();


            this.CmbDept.SelectedValue = m.deptID;


        }

        /// <summary>
        /// save data after change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAfterChange(object sender, EventArgs e)
        {
            addressBook m = new addressBook();

            m.engDepartment = txtDepartmentEnglishName.Text;
            m.chinessName = TxtName.Text;
            m.deptID = CmbDept.SelectedValue.ToString();
            m.Ext =TxtExt.Text==""? (Nullable<double>) null : Convert.ToDouble( TxtExt.Text);
            m.mobilePhoneNumber = TxtTel.Text == "" ? (Nullable<double>)null : Convert.ToDouble(TxtTel.Text);

            Expression<Func<addressBook, bool>> expression = s => s.ID == this.id;
            //new UpdateService().Upadate<AddressBookModel, ItContext>
                new UpdateService().Update<addressBook,ItContext>
            (expression , m);
        }

        #endregion

      
    }
}
