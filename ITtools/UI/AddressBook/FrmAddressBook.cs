﻿using ITtools.DAL.Services.AddressBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
            InitialContolDataSource();
            this.FormClosed += CloseParentForm;

        }

      void  InitialContolDataSource()
        {

            //CmbDept.DataSource = new DepartmentService().GetDepanrtmentList();
            CmbDept.DataSource = new DepartmentService().GetDepartment();
            CmbDept.ValueMember = "deptID";
            CmbDept.DisplayMember = "deptName";

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
            AddressBookServce addressBook = new AddressBookServce();

            SqlParameter[] sqlparameters = {
                new  SqlParameter("@department", CmbDept.Text.ToString()) };
            
            dataGridView1.DataSource = addressBook.GetAddresBookInDataTable(sqlparameters);
        }
    }
}
