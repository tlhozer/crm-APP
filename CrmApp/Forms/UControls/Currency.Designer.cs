namespace CrmApp.Forms.UControls
{
    partial class Currency
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Dovizbtn = new Guna.UI2.WinForms.Guna2Button();
            this.DovizLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dovizlist = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Dovizbtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DovizLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.83815F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 692);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Dovizbtn
            // 
            this.Dovizbtn.BorderRadius = 3;
            this.Dovizbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Dovizbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Dovizbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Dovizbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Dovizbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dovizbtn.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.Dovizbtn.ForeColor = System.Drawing.Color.White;
            this.Dovizbtn.Location = new System.Drawing.Point(3, 101);
            this.Dovizbtn.Name = "Dovizbtn";
            this.Dovizbtn.Size = new System.Drawing.Size(814, 68);
            this.Dovizbtn.TabIndex = 0;
            this.Dovizbtn.Text = "Döviz Çek";
            this.Dovizbtn.Click += new System.EventHandler(this.Dovizbtn_Click);
            // 
            // DovizLbl
            // 
            this.DovizLbl.AutoSize = false;
            this.DovizLbl.BackColor = System.Drawing.Color.Transparent;
            this.DovizLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DovizLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DovizLbl.Location = new System.Drawing.Point(3, 3);
            this.DovizLbl.Name = "DovizLbl";
            this.DovizLbl.Size = new System.Drawing.Size(814, 92);
            this.DovizLbl.TabIndex = 1;
            this.DovizLbl.Text = "0";
            this.DovizLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dovizlist, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.guna2HtmlLabel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 175);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(814, 100);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dovizlist
            // 
            this.dovizlist.BackColor = System.Drawing.Color.Transparent;
            this.dovizlist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dovizlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dovizlist.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dovizlist.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dovizlist.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dovizlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dovizlist.ItemHeight = 39;
            this.dovizlist.Items.AddRange(new object[] {
            "Seç",
            "Dolar",
            "Euro",
            "Sterlin"});
            this.dovizlist.Location = new System.Drawing.Point(3, 53);
            this.dovizlist.Name = "dovizlist";
            this.dovizlist.Size = new System.Drawing.Size(243, 45);
            this.dovizlist.StartIndex = 0;
            this.dovizlist.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(401, 44);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Döviz Listesi";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Currency";
            this.Size = new System.Drawing.Size(820, 692);
            this.Load += new System.EventHandler(this.Currency_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button Dovizbtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel DovizLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2ComboBox dovizlist;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
