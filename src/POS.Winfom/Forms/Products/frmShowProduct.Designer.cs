namespace POW.Winfom.Forms.Products;

partial class frmShowProduct
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        dgvProducts = new Guna.UI2.WinForms.Guna2DataGridView();
        txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
        cmbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        cmsProduct = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
        تعديلToolStripMenuItem = new ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
        cmsProduct.SuspendLayout();
        SuspendLayout();
        // 
        // dgvProducts
        // 
        dgvProducts.AllowUserToAddRows = false;
        dgvProducts.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.White;
        dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvProducts.ColumnHeadersHeight = 4;
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        dgvProducts.ContextMenuStrip = cmsProduct;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
        dgvProducts.GridColor = Color.FromArgb(231, 229, 255);
        dgvProducts.Location = new Point(12, 199);
        dgvProducts.Name = "dgvProducts";
        dgvProducts.ReadOnly = true;
        dgvProducts.RowHeadersVisible = false;
        dgvProducts.RowHeadersWidth = 51;
        dgvProducts.Size = new Size(1238, 462);
        dgvProducts.TabIndex = 1;
        dgvProducts.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        dgvProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
        dgvProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
        dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
        dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
        dgvProducts.ThemeStyle.BackColor = Color.White;
        dgvProducts.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
        dgvProducts.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
        dgvProducts.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
        dgvProducts.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
        dgvProducts.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        dgvProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        dgvProducts.ThemeStyle.HeaderStyle.Height = 4;
        dgvProducts.ThemeStyle.ReadOnly = true;
        dgvProducts.ThemeStyle.RowsStyle.BackColor = Color.White;
        dgvProducts.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvProducts.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
        dgvProducts.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        dgvProducts.ThemeStyle.RowsStyle.Height = 29;
        dgvProducts.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dgvProducts.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        // 
        // txtSearch
        // 
        txtSearch.CustomizableEdges = customizableEdges1;
        txtSearch.DefaultText = "";
        txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        txtSearch.Font = new Font("Segoe UI", 9F);
        txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        txtSearch.Location = new Point(167, 158);
        txtSearch.Margin = new Padding(3, 4, 3, 4);
        txtSearch.Name = "txtSearch";
        txtSearch.PasswordChar = '\0';
        txtSearch.PlaceholderText = "اكتب هنا للبحث";
        txtSearch.RightToLeft = RightToLeft.No;
        txtSearch.SelectedText = "";
        txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
        txtSearch.Size = new Size(879, 36);
        txtSearch.TabIndex = 1;
        txtSearch.TextAlign = HorizontalAlignment.Center;
        // 
        // cmbFilter
        // 
        cmbFilter.BackColor = Color.Transparent;
        cmbFilter.CustomizableEdges = customizableEdges3;
        cmbFilter.DrawMode = DrawMode.OwnerDrawFixed;
        cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbFilter.FocusedColor = Color.FromArgb(94, 148, 255);
        cmbFilter.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        cmbFilter.Font = new Font("Segoe UI", 10F);
        cmbFilter.ForeColor = Color.FromArgb(68, 88, 112);
        cmbFilter.ItemHeight = 30;
        cmbFilter.Items.AddRange(new object[] { "كود الصنف", "اسم الصنف" });
        cmbFilter.Location = new Point(12, 158);
        cmbFilter.Name = "cmbFilter";
        cmbFilter.RightToLeft = RightToLeft.Yes;
        cmbFilter.ShadowDecoration.CustomizableEdges = customizableEdges4;
        cmbFilter.Size = new Size(149, 36);
        cmbFilter.StartIndex = 1;
        cmbFilter.TabIndex = 0;
        // 
        // guna2Button1
        // 
        guna2Button1.Cursor = Cursors.Hand;
        guna2Button1.CustomizableEdges = customizableEdges5;
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.FillColor = Color.LimeGreen;
        guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        guna2Button1.ForeColor = Color.White;
        guna2Button1.Location = new Point(1052, 158);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
        guna2Button1.Size = new Size(198, 36);
        guna2Button1.TabIndex = 3;
        guna2Button1.Text = "إضافة صنف";
        // 
        // cmsProduct
        // 
        cmsProduct.ImageScalingSize = new Size(20, 20);
        cmsProduct.Items.AddRange(new ToolStripItem[] { تعديلToolStripMenuItem });
        cmsProduct.Name = "cmsProduct";
        cmsProduct.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
        cmsProduct.RenderStyle.BorderColor = Color.Gainsboro;
        cmsProduct.RenderStyle.ColorTable = null;
        cmsProduct.RenderStyle.RoundedEdges = true;
        cmsProduct.RenderStyle.SelectionArrowColor = Color.White;
        cmsProduct.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
        cmsProduct.RenderStyle.SelectionForeColor = Color.White;
        cmsProduct.RenderStyle.SeparatorColor = Color.Gainsboro;
        cmsProduct.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
        cmsProduct.Size = new Size(116, 28);
        // 
        // تعديلToolStripMenuItem
        // 
        تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
        تعديلToolStripMenuItem.Size = new Size(115, 24);
        تعديلToolStripMenuItem.Text = "تعديل";
        // 
        // frmShowProduct
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1262, 673);
        Controls.Add(guna2Button1);
        Controls.Add(cmbFilter);
        Controls.Add(txtSearch);
        Controls.Add(dgvProducts);
        FormBorderStyle = FormBorderStyle.None;
        Name = "frmShowProduct";
        StartPosition = FormStartPosition.CenterScreen;
        Load += frmShowProduct_Load;
        ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
        cmsProduct.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Guna.UI2.WinForms.Guna2DataGridView dgvProducts;
    private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    private Guna.UI2.WinForms.Guna2ComboBox cmbFilter;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsProduct;
    private ToolStripMenuItem تعديلToolStripMenuItem;
}