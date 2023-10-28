using CrmApp.Forms.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmApp
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        
        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            MenuFrm menuFrm = new MenuFrm();
            menuFrm.ShowDialog();
            this.Hide();
        }

        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
