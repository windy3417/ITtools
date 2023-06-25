using ITtools.DAL.Services.AddressBook;
using ITtools.DAL.VModel;
using ITtools.Model;
using ITtools.Model.IT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.Sql;


namespace ITtools.UI.AddressBook
{
    public partial class FrmAddressBook : Form
    {
        public FrmAddressBook()
        {
            InitializeComponent();
            InitialControls();
            InitialContolDataSource();
            this.FormClosed += CloseParentForm;

        }

        #region style

        void InitialControls()
        {
           new Utility.Style.DataGridViewStyle().DataGridViewColumnHeaderStyle(dataGridView1);
           Utility.Style.DataGridViewDoubleBuffer.DoubleBuffered(dataGridView1, true);
        }


        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var s = new Utility.Style.DataGridViewStyle();

            s.DisplayRowNo(e, dataGridView1,false);

        }

        #endregion

        void InitialContolDataSource()
        {

            //CmbDept.DataSource = new DepartmentService().GetDepanrtmentList();
            CmbDept.DataSource = new DepartmentService().GetDepartment();
            CmbDept.ValueMember = "deptID";
            CmbDept.DisplayMember = "deptName";
            //默认值为空
            CmbDept.SelectedIndex = -1;

        }

        private void CloseParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void BindDataSource()
        {
            //Sqlhelper.GetDataTable(sql,Sqlhelper.DataSourceType.);
        }

        private void TsbQuery_Click(object sender, EventArgs e)
        {
            addressBook m = new addressBook();

            string[] properties = { "memoryCode", "department" };


            string[] ops = { "Contains", "==" };
            object[] values = { string.IsNullOrEmpty(txtPersonName.Text)? null:txtPersonName.Text, string.IsNullOrEmpty(CmbDept.Text)? null :CmbDept.Text };


           

            using (var db = new ItContext())
            {
                var address = from s in db.addressBook
                              join b in db.Department
                              on s.deptID equals b.deptID
                              select new {s.ID,s.deptID, b.deptName,s.memoryCode, s.chinessName, s.Ext,s.mobilePhoneNumber, s.emailAddress };

                var query = address.AsQueryable();

                for (int i = 0; i < properties.Length; i++)
                {
                    if (!string.IsNullOrEmpty(properties[i]) && !string.IsNullOrEmpty(ops[i]) && values[i] != null)
                    {
                        if (ops[i] == "Contains")
                        {
                            query = query.Where($"{properties[i]}.Contains(@0)", values[i]);
                        }
                        else
                        {
                            query = query.Where($"{properties[i]} {ops[i]} @0", values[i]);
                        }
                       
                    }
                }

                this.departmanetName.DataPropertyName = "deptName";
                this.personName.DataPropertyName = "chinessName";
                this.ExNo.DataPropertyName = "Ext";
                this.email.DataPropertyName = "emailAddress";
                this.cellPhone.DataPropertyName = "mobilePhoneNumber";

                dataGridView1.DataSource = query.ToList();




            }
        }





        private void TsbAddressBookUpdate_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.CurrentRow != null)
            {
                FrmAddUpdateAddresBook f = new FrmAddUpdateAddresBook();
                f.Text = "通讯录修改";
                f.update(Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value));
                f.Show();

            }
        }

        private bool GetCondition(addressBook m, string memoryCode, string deptId)



        {
            bool boolResult = true;
            if (!String.IsNullOrEmpty(memoryCode))
            {
                boolResult &= m.memoryCode == memoryCode;
            }

            if (!String.IsNullOrEmpty(deptId))
            {
                boolResult &= m.deptID.Trim() == deptId;
            }

            return boolResult;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Expression<Func<addressBook, bool>> expression = i => i.ID == Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            Utility.DAL.DeleteService.DeletSingleRow<addressBook, ItContext>(dataGridView1,expression);
        }

    }
}

