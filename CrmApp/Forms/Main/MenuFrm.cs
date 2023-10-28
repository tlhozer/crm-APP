using CrmApp.Engines;
using CrmApp.Forms.UControls;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmApp.Forms.Main
{
    public partial class MenuFrm : Form
    {
        private string page = "";
        private object previousSender;
        public MenuFrm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelClear(object sender)
        {
            Panel.Controls.Clear();
            Guna2TileButton tiklanan = sender as Guna2TileButton;
            tiklanan.ForeColor = Color.White;

            if (previousSender != null)
            {
                Guna2TileButton oncekitiklanan = previousSender as Guna2TileButton;
                oncekitiklanan.FillColor = Color.FromArgb(47, 54, 64);
                oncekitiklanan.ForeColor = Color.White;
            }
            previousSender = sender;
        }

        private void BtnActive(object sender)
        {
            Guna2TileButton tiklanan = sender as Guna2TileButton;
            tiklanan.FillColor = SystemColors.Window;
            tiklanan.ForeColor = Color.Black;
        }
        private void MenuFrm_Load(object sender, EventArgs e)
        {
            FormEngine.BuildAndRun(this);
        }

        private void CustomerListBtn_Click(object sender, EventArgs e)
        {
            if (page == "customerlist")
            {
            }
            else
            {
                PanelClear(sender);
                Customer customer = new Customer();
                customer.Size = new Size(Panel.Size.Width, Panel.Size.Height);
                Panel.Controls.Add(customer);
                BtnActive(sender);
                page = "customerlist";
            }
        }

        private void PatientBtn_Click(object sender, EventArgs e)
        {
            if (page == "productlist")
            {
            }
            else
            {
                PanelClear(sender);
                Product product = new Product();
                product.Size = new Size(Panel.Size.Width, Panel.Size.Height);
                Panel.Controls.Add(product);
                BtnActive(sender);
                page = "productlist";
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void Currency_Click(object sender, EventArgs e)
        {

            if (page == "currency")
            {
            }
            else
            {
                PanelClear(sender);
                Currency currency = new Currency();
                currency.Size = new Size(Panel.Size.Width, Panel.Size.Height);
                Panel.Controls.Add(currency);
                BtnActive(sender);
                page = "currency";
            }
        }

        private void Settingsbtn_Click(object sender, EventArgs e)
        {
            if (page == "settings")
            {
            }
            else
            {
                PanelClear(sender);
                Settings settings = new Settings();
                settings.Size = new Size(Panel.Size.Width, Panel.Size.Height);
                Panel.Controls.Add(settings);
                BtnActive(sender);
                page = "settings";
            }
        }

        private void ProductAdd_Click(object sender, EventArgs e)
        {
            if (page == "productadd")
            {
            }
            else
            {
                PanelClear(sender);
                ProductAdd product = new ProductAdd();
                product.Size = new Size(Panel.Size.Width, Panel.Size.Height);
                Panel.Controls.Add(product);
                BtnActive(sender);
                page = "productadd";
            }

        }

        private void GiveOfferBtn_Click(object sender, EventArgs e)
        {
            if (page == "giveoffer")
            {
            }
            else
            {
                PanelClear(sender);
                Giveoffer giveoffer = new Giveoffer();
                giveoffer.Size = new Size(Panel.Size.Width, Panel.Size.Height);
                Panel.Controls.Add(giveoffer);
                BtnActive(sender);
                page = "giveoffer";
            }
        }

        private void CustomerAdd_Click(object sender, EventArgs e)
        {
            if (page == "customeradd")
            {
            }
            else
            {
                PanelClear(sender);
                CustomerAdd customerAdd = new CustomerAdd();
                customerAdd.Size = new Size(Panel.Size.Width, Panel.Size.Height);
                Panel.Controls.Add(customerAdd);
                BtnActive(sender);
                page = "customeradd";
            }
        }
    }
}
