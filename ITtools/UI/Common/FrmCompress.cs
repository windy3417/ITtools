using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITtools.UI
{
    public partial class FrmCompress : Form
    {
        public FrmCompress()
        {
            InitializeComponent();
            this.FormClosed += CloseParentForm;
        }

        private void CloseParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void TsbChoose_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Title = "选取要压缩的图片";
            string originalFileFullName =openFileDialog1.FileName ;
            
            folderBrowserDialog1.ShowDialog();
            

            //压缩后的文件名
            string afterConversionFileFullName =folderBrowserDialog1.SelectedPath + @"E:\6.jpg";
            CompressImage(originalFileFullName, afterConversionFileFullName, 99, 100);
        }

        /// <summary>
        /// 无损压缩图片
        /// </summary>
        /// <param name="originalFileFullName">原图片地址</param>
        /// <param name="afterConversionFileFullName">压缩后保存图片地址</param>
        /// <param name="flag">压缩质量（数字越小压缩率越高）1-100</param>
        /// <param name="size">压缩后图片的最大大小</param>
        /// <param name="isFirst">是否是第一次调用</param>
        /// <returns></returns>
        public static bool CompressImage(string originalFileFullName,
            string afterConversionFileFullName,
            int flag = 90, int size = 300, bool isFirst = true)
        {
            Image iSource = Image.FromFile(originalFileFullName);
            ImageFormat tFormat = iSource.RawFormat;
            //如果是第一次调用，原始图像的大小小于要压缩的大小，则直接复制文件，并且返回true
            FileInfo firstFileInfo = new FileInfo(originalFileFullName);
            if (isFirst == true && firstFileInfo.Length < size * 1024)
            {
                firstFileInfo.CopyTo(afterConversionFileFullName);
                return true;
            }

            int dHeight = iSource.Height / 2;
            int dWidth = iSource.Width / 2;
            int sW = 0, sH = 0;
            //按比例缩放
            Size tem_size = new Size(iSource.Width, iSource.Height);
            if (tem_size.Width > dHeight || tem_size.Width > dWidth)
            {
                if ((tem_size.Width * dHeight) > (tem_size.Width * dWidth))
                {
                    sW = dWidth;
                    sH = (dWidth * tem_size.Height) / tem_size.Width;
                }
                else
                {
                    sH = dHeight;
                    sW = (tem_size.Width * dHeight) / tem_size.Height;
                }
            }
            else
            {
                sW = tem_size.Width;
                sH = tem_size.Height;
            }

            Bitmap ob = new Bitmap(dWidth, dHeight);
            Graphics g = Graphics.FromImage(ob);

            g.Clear(Color.WhiteSmoke);
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            g.DrawImage(iSource, new Rectangle((dWidth - sW) / 2, (dHeight - sH) / 2, sW, sH), 0, 0,
                iSource.Width, iSource.Height, GraphicsUnit.Pixel);

            g.Dispose();

            //以下代码为保存图片时，设置压缩质量
            EncoderParameters ep = new EncoderParameters();
            long[] qy = new long[1];
            qy[0] = flag;//设置压缩的比例1-100
            EncoderParameter eParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qy);
            ep.Param[0] = eParam;

            try
            {
                ImageCodecInfo[] arrayICI = ImageCodecInfo.GetImageEncoders();
                ImageCodecInfo jpegICIinfo = null;
                for (int x = 0; x < arrayICI.Length; x++)
                {
                    if (arrayICI[x].FormatDescription.Equals("JPEG"))
                    {
                        jpegICIinfo = arrayICI[x];
                        break;
                    }
                }
                if (jpegICIinfo != null)
                {
                    //保存图像
                    ob.Save(afterConversionFileFullName, jpegICIinfo, ep);
                    FileInfo fi = new FileInfo(afterConversionFileFullName);
                    if (fi.Length > 1024 * size)
                    {
                        flag = flag - 10;
                        CompressImage(originalFileFullName, afterConversionFileFullName, flag, size, false);
                    }
                }
                else
                {
                    ob.Save(afterConversionFileFullName, tFormat);
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                iSource.Dispose();
                ob.Dispose();
            }
        }

        private void TsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
