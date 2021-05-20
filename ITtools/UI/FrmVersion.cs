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
    public partial class FrmVersion : Form
    {
        public FrmVersion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmVersion_Load(object sender, EventArgs e)
        {
            Content.Text = "程序集版本：" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\n";


            Content.Text += "文件版本：" + Application.ProductVersion.ToString() + "\n";
            //显示click once 部署的版本信息，只有在部署成功后才能正确显示，调试时会报异常
            Content.Text += "部署版本：" + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
        }
    }
}
