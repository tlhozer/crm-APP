using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmApp.Forms.UControls
{
    public partial class ProductAdd : UserControl
    {
        public ProductAdd()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImageChooseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                 openFileDialog.ShowDialog();
            openFileDialog.Filter = "Resim Dosyası |*.jpg | Video|*.avi| Tüm Dosyalar |*.*";
 
            string DosyaYolu = openFileDialog.FileName;
            ImagePic.ImageLocation = DosyaYolu;
            }
           
           
        }
    }
}
