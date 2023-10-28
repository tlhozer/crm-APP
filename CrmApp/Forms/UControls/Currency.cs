using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CrmApp.Forms.UControls
{
    public partial class Currency : UserControl
    {
        
        public Currency()
        {
            InitializeComponent();
        }
      
        private void Currency_Load(object sender, EventArgs e)
        {

        }

       


        void Dolar()
        {
            XmlDocument xmlVerisi = new XmlDocument();
            xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
            DovizLbl.Text = dolar.ToString();
        }

        void Euro()
        {
            XmlDocument xmlVerisi = new XmlDocument();
            xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
            DovizLbl.Text = euro.ToString();
        }


        void Sterlin()
        {
            XmlDocument xmlVerisi = new XmlDocument();
            xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ','));
            DovizLbl.Text = sterlin.ToString();
        }
        private void Dovizbtn_Click(object sender, EventArgs e)
        {
            if(dovizlist.Text == "Dolar")
            {
                Dolar();
            }

            else if(dovizlist.Text == "Euro")
            {
                Euro();
            }

            else if(dovizlist.Text == "Sterlin")
            {
                Sterlin();
            }
        }

     

     
    }
}
