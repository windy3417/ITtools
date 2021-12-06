using ITtools.Model.DAL.Services;
using ITtools.Model.IT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void TsbQuery_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = new QueryService<department>().GetDataList();
        }

        private void TsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
