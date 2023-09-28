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
using ITtools.Model.Scrap;
using ITtools.Test;
using Utility.DAL;

namespace ITtools.UI.ScrapMantinance
{
    public partial class FrmScrapUpdate : Form
    {
        public FrmScrapUpdate()
        {
            InitializeComponent();
            InitialControsData();
            txtVoucherNo.Enabled = false;
            TxtNetWeight.Enabled = false;
            txtSkinWeight.Enabled = false;

            cmbSpecies.Enabled = false;

        }

        void InitialControsData()
        {
            var dataSource = QueryService.GetDataList<Scrap>(Utility.Sql.Sqlhelper.DataSourceType.business);
            cmbSpecies.DataSource = dataSource;
            cmbSpecies.DisplayMember = "ScrapName";
            cmbSpecies.ValueMember = "ScrapCode";
            

        }

        bool updateNetWeightFlag=false;
        bool modifySpeciesFlag = false;


        public WeighingSettlement m= new WeighingSettlement();



        private void FrmScrapUpdate_Load(object sender, EventArgs e)
        {
            txtMemo.Text = m.note;
            txtVoucherNo.Text = m.vocherNO;
            TxtNetWeight.Text = m.netWeight.ToString();
            txtSkinWeight.Text = m.Tare.ToString();

            foreach (Scrap item in (List<Scrap>)cmbSpecies.DataSource)
            {
                if (item.ScrapCode.ToString()== m.scrapCode)
                {
                    cmbSpecies.SelectedItem = item;
                    
                    break;
                }
            }
    

        }

        private void TsbSave_Click(object sender, EventArgs e)
        {
            if (updateNetWeightFlag)
            {
                try
                {
                    using (var db = new ScrapContext())
                    {
                        WeighingSettlement m = db.WeighingSettlement.Where(s => s.vocherNO == txtVoucherNo.Text).FirstOrDefault();

                        m.note = txtMemo.Text;
                        m.netWeight = Convert.ToDouble(TxtNetWeight.Text);
                        m.Tare= Convert.ToDouble(txtSkinWeight.Text);

                        db.SaveChanges();

                        if (MessageBox.Show("修改成功！", "过磅单修改", MessageBoxButtons.OK, MessageBoxIcon.Information)
                           == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            if (modifySpeciesFlag)
            {
                try
                {
                    //using (var db = new ScrapContext())
                    //{
                    //    WeighingSettlement m = db.WeighingSettlement.Where(s => s.vocherNO == txtVoucherNo.Text).FirstOrDefault();

                    //    m.scrapCode = cmbSpecies.SelectedValue.ToString();


                    //    db.SaveChanges();

                    //    if (MessageBox.Show("品种修改成功！", "过磅单修改", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    //       == DialogResult.OK)
                    //    {
                    //        this.Close();
                    //    }
                    //}
                    WeighingSettlement m = new WeighingSettlement();
                    Utility.DAL.UpdateService.Update<WeighingSettlement>(m, "scrapCode", cmbSpecies.SelectedValue, "vocherNO",
                                       new SqlParameter[] { new SqlParameter("@vocherNO", txtVoucherNo.Text) });  
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message+ex.InnerException);
                }
            }
            //modify note
            else
            {
                try
                {
                    using (var db = new ScrapContext())
                    {
                        WeighingSettlement m = db.WeighingSettlement.Where(s => s.vocherNO == txtVoucherNo.Text).FirstOrDefault();

                        m.note = txtMemo.Text;
                       

                        db.SaveChanges();

                        if (MessageBox.Show("修改成功！", "过磅单修改", MessageBoxButtons.OK, MessageBoxIcon.Information)
                           == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void TsbUpdateNetWeight_Click(object sender, EventArgs e)
        {
            TxtNetWeight.Enabled = true;
            txtSkinWeight.Enabled = true;

            updateNetWeightFlag = true;
        }

        private void tsbModifySpecies_Click(object sender, EventArgs e)
        {
            cmbSpecies.Enabled = true;

            modifySpeciesFlag = true;
        }
    }
    }

