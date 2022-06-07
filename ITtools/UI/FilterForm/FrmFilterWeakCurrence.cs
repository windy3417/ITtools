using ITtools.DAL.Services;
using ITtools.DAL.VModel;
using ITtools.Model.U8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITtools.UI.FilterForm
{
    public partial class FrmFilterWeakCurrent : Form
    {
        public FrmFilterWeakCurrent()
        {
            InitializeComponent();
        }


        #region delegate

       public Action<List<ProjectSettleVmodel>> ActionListProject;
        #endregion

        /// <summary>
        /// return data to form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbCertain_Click(object sender, EventArgs e)
        {
            Expression<Func<PU_AppVouch, bool>> exp = s => Filter(s);
            this.Cursor = Cursors.WaitCursor;
            ActionListProject?.Invoke(new ProjectSettleService().getProject(exp));
            this.Close();
            
        }


        bool Filter(PU_AppVouch m)
        {
            bool result = true;
            if (!String.IsNullOrEmpty(dtpStartDate.Value.ToLongDateString()))
            {
                result &= m.dDate >= dtpStartDate.Value.Date;
            }

            if (!String.IsNullOrEmpty(dtpEndDate.Value.ToLongDateString()))
            {
                result &= m.dDate <= dtpEndDate.Value.Date;
            }

            if (!String.IsNullOrEmpty(cmbStatus.Text?.ToString()))
            {

                switch (cmbStatus.Text)
                {
                  case  "关闭"  :  result &= m.cCloser != null;
                break;
                    case "审核": result &= m.cCloser == null;
                        break;

                }
             
               
            }

            return result;

        }
    }
}
