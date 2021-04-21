﻿using System;
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
            using (var db=new ItContext())
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

        }
    }
}
