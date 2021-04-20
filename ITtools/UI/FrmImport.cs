using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITtools.UI
{
    public partial class FrmImport : Form
    {
        public FrmImport()
        {
            InitializeComponent();
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
    }
}
