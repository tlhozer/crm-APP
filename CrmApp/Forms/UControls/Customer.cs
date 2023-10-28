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
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
            
        }

        private void Customer_Load(object sender, EventArgs e)
        {

           


        }

        private void AdjustDataGridViewHeaderWidth(DataGridView dgv)
        {
            // Tüm sütun başlıklarının genişliğini ayarla
            int totalWidth = dgv.ClientSize.Width;
            int columnCount = dgv.Columns.Count;

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.Width = totalWidth / columnCount;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Hizala
            }
        }
        private void ExpandHeaderWidth(DataGridViewColumn column, int additionalWidth)
        {
            // Başlık genişliğini artır
            column.HeaderCell.Style.Padding = new Padding(additionalWidth, 0, additionalWidth, 0);
        }

        private void Customer_Leave(object sender, EventArgs e)
        {

        }
    }
}
