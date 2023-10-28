using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmApp.Forms.UControls
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
            {
                guna2DataGridView1.Rows[i].Height = 39;
            }
        }
    }
}
