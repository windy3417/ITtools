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

namespace ITtools.UI.AddressBook
{
    public partial class FrmAddresBookAddUpdate : Form
    {
        public FrmAddresBookAddUpdate()
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
        private void TsbSave_Click(object sender, EventArgs e)
        {
            AddressBookModel m = new AddressBookModel();
            m.chinessName = TxtName.Text;
            m.deptID = CmbDept.SelectedValue.ToString();
            m.Ext = TxtExt.Text == "" ? (Nullable<double>)null : Convert.ToDouble(TxtExt.Text);
            m.emailAddress = TxtEmail.Text;
            m.memoryCode = TinyPinyin.Core.PinyinHelper.GetPinyinInitials(TxtName.Text);

            Utility.DAL.SaveService saveService = new Utility.DAL.SaveService();
            saveService.SaveSingleDate<AddressBookModel, ItContext>(m);

        }

        #endregion
        private void CloseParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void TsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

        #region update data

        int id;
        
        /// <summary>
        /// 被主窗体调用
        /// </summary>
        /// <param name="id"></param>
      public  void update(int id)
        {
            this.TsbSave.Visible = false;
            this.id = id;
            ToolStripButton btnUpdate = new ToolStripButton();
            btnUpdate.Text = "保存";
            btnUpdate.Image = Properties.Resources.save;
            toolStrip1.Items.Add(btnUpdate);

            btnUpdate.Click += BtnUpdate_Click;

            Expression<Func<AddressBookModel, bool>> expression = s => s.emailAddress == "test";
          var sql=  new JQ.Expressions.SqlServerVisitor().GetSqlWhere(expression);
 


        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            AddressBookModel m = new AddressBookModel();
            m.chinessName = TxtName.Text;
            m.deptID = CmbDept.SelectedValue.ToString();
            m.Ext =TxtExt.Text==""? (Nullable<double>) null : Convert.ToDouble( TxtExt.Text);
            m.mobilePhoneNumber = TxtTel.Text == "" ? (Nullable<double>)null : Convert.ToDouble(TxtTel.Text);

            Expression<Func<AddressBookModel, bool>> expression = s => s.ID == this.id;
            new UpdateService().Upadate<AddressBookModel, ItContext>
            (expression , m);
        }

        #endregion
    }
}
