using ITtools.DAL.Services;
using ITtools.DAL.VModel;
using ITtools.Model.IT;
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
            SetDefaultValue();
        }


        #region delegate

       public Action<List<WeakCurrentSettleVmodel>> ActionProjectList;
        #endregion


        /// <summary>
        /// return data to form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbCertain_Click(object sender, EventArgs e)
        {
            Expression<Func<PU_AppVouch, bool>> exp1 = s => Filter(s); 
            Expression<Func<PrWeakCurrent, bool>> exp2 = s => Filter(s);
            this.Cursor = Cursors.WaitCursor;
            ActionProjectList?.Invoke(new WeakCurrenceSettleService().getProject(exp1,exp2));
            this.Close();
            
        }

        #region filter

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
                    case "关闭":
                        result &= m.cCloser != null;
                        break;
                    case "审核":
                        result &= m.cCloser == null;
                        break;

                }


            }

            return result;

        }


        bool Filter(PrWeakCurrent m)
        {
            bool result = true;
        

            if (!String.IsNullOrEmpty(cmbProjectPocesss.Text?.ToString()))
            {

                switch (cmbProjectPocesss.Text)
                {
                    case "验收":
                        result &= m.isSettle ==true;
                        break;
                    case "开立":
                        result &= m.isSettle == false ;
                        break;

                }


            }

            return result;

        }

        #endregion



        void SetDefaultValue()
        {
            dtpStartDate.Value = DateTime.Now.AddMonths(-DateTime.Now.Month + 1).AddDays(-DateTime.Now.Day + 1);
            cmbProjectPocesss.Text = "开立";
            cmbStatus.Text = "";
            //cmbStatus.Text=
        }
    }
}
