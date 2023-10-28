using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace CrmApp.Forms.UControls
{
    public partial class Giveoffer : UserControl
    {
        public Giveoffer()
        {
            InitializeComponent();
            InitializeTextBoxes();
        }

        private void GenerateGiveOfferBtn_Click(object sender, EventArgs e)
        {
           
        }
        private void InitializeTextBoxes()
        {
            // TextBox olaylarına odaklanma olaylarını ekleyin
            CompanyNameTxt.KeyDown += TextBox_KeyDown;
            CompanyNameTxt.KeyDown += TextBox_KeyDown;


            // İlk TextBox'a varsayılan olarak odaklan
            CompanyNameTxt.Focus();
        }
        private void Giveoffer_Load(object sender, EventArgs e)
        {
            
        }

        public void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Eğer Enter tuşuna basıldıysa ve sender bir TextBox ise
            if (e.KeyCode == Keys.Enter && sender is TextBox currentTextBox)
            {
                // Geçerli TextBox'ı bul
                Control nextControl = GetNextControl(currentTextBox, true);

                // Bir sonraki kontrol bir TextBox ise, ona odaklan
                if (nextControl is TextBox)
                {
                    nextControl.Focus();
                }

                // "Enter" tuşunun varsayılan işlemi engellensin
                e.SuppressKeyPress = true;
            }
        }
    }
}
