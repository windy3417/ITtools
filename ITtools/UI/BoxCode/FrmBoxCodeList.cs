﻿using ITtools.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITtools.UI.BoxCode
{
    public partial class FrmBoxCodeList : Form
    {
        public FrmBoxCodeList()
        {
            InitializeComponent();
            InitialControlDataSource();
        }

       void InitialControlDataSource()
        {
            dataGridView1.AutoGenerateColumns = false;
            
            boxCode.DataPropertyName = "BoxCode";
            makeDate.DataPropertyName = "MakeDate";
            invCode.DataPropertyName = "InvCode";
            invName.DataPropertyName = "InvName";
            invStd.DataPropertyName = "InvStd";
            natruralFlowCode.DataPropertyName = "NaturalFlowCode";
            dataFlow.DataPropertyName = "DateFlowCode";
            createUser.DataPropertyName = "CreateUserName";

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            using (var db=new U8Context())
            {
                var list = from s in db.Xm_BoxCode
                           join i in db.Xm_BoxCodeItem on s.BoxCode equals i.BoxCode
                           where s.InvCode == txtInvCode.Text
                           select new {i.ID, s.MakeDate, s.InvCode, s.InvName, s.InvStd, s.BoxCode,i.DateFlowCode,i.NaturalFlowCode, s.CreateUserCode, s.CreateUserName };
                
                dataGridView1.DataSource = list.ToList();
            }

            this.Cursor = Cursors.Default;
        }
    }
}
