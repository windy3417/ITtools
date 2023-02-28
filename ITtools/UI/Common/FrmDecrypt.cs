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

namespace ITtools.UI
{
    public partial class FrmDecrypt : Form
    {
        public FrmDecrypt()
        {
            InitializeComponent();
            this.FormClosed += closeParentForm;
        }

        private void closeParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = Utility.Encrypt.Decode(RtbEncryptCharacter.Text);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbEncrypt_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = Utility.Encrypt.Encode(RtbEncryptCharacter.Text);
        }

        private void tsbDecrypt_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = Utility.Encrypt.Decode(RtbEncryptCharacter.Text);
        }

        private void tsbByteToChar_Click(object sender, EventArgs e)
        {

            #region ritrieve the data form database
            //rtbOutput.Text = new Utility.Files.FilesOperate().ByteToChar(RtbEncryptCharacter.Text);
            // Connection string for the database

            string connectionString = "Data Source=192.168.10.66;Initial Catalog=windy;User ID=sa;Password=ximai85477560";

            // SQL query to retrieve the varbinary column value
            string sqlQuery = "SELECT [Model] FROM [__MigrationHistory] WHERE MigrationId =@miid";

            // Create a SqlConnection object and open the connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a SqlCommand object and execute the query
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@miid", "202106300323149_m2");

                    // Retrieve the varbinary column value as a byte array

                    byte[] varbinaryValue = (byte[])command.ExecuteScalar();

                    // Convert the byte array to a string using UTF8 encoding
                    string stringValue = Encoding.UTF8.GetString(varbinaryValue);

                    // Set the Text property of the RichTextBox control to the string value
                    rtbOutput.Text = stringValue;
                    #endregion

                    #region MyRegion
                    //string hexString = RtbEncryptCharacter.Text; // hexadecimal string
                    //byte[] bytes = Enumerable.Range(0, hexString.Length)
                    //                         .Where(x => x % 2 == 0)
                    //                         .Select(x => Convert.ToByte(hexString.Substring(x, 2), 16))
                    //                         .ToArray(); // convert to byte array

                    //// print each byte value
                    //rtbOutput.Text = Encoding.UTF8.GetString(bytes);
                    ////rtbOutput.Text = bytes.ToString()
                    ////
                    ////;

                    ////StringBuilder stringBuilder = new StringBuilder();
                    ////foreach (var item in bytes)
                    ////{
                    ////    stringBuilder.Append(item.ToString());
                    ////}

                    ////rtbOutput.Text = stringBuilder.ToString();
                    #endregion


                }
            }
        }
    }
}
