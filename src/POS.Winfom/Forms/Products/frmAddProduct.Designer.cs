namespace POW.Winfom.Forms.Products;

partial class frmAddProduct
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
        components = new System.ComponentModel.Container();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        txtName = new Guna.UI2.WinForms.Guna2TextBox();
        guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
        guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
        guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
        txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
        txtProductNumber = new Guna.UI2.WinForms.Guna2TextBox();
        btnSave = new Guna.UI2.WinForms.Guna2Button();
        errorProvider1 = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        SuspendLayout();
        // 
        // txtName
        // 
        txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        txtName.BorderColor = Color.Gray;
        txtName.BorderRadius = 5;
        txtName.CustomizableEdges = customizableEdges1;
        txtName.DefaultText = "";
        txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        txtName.Font = new Font("Segoe UI", 9F);
        txtName.ForeColor = Color.Black;
        txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        txtName.Location = new Point(39, 63);
        txtName.Margin = new Padding(3, 4, 3, 4);
        txtName.Name = "txtName";
        txtName.PasswordChar = '\0';
        txtName.PlaceholderText = "";
        txtName.SelectedText = "";
        txtName.ShadowDecoration.CustomizableEdges = customizableEdges2;
        txtName.Size = new Size(314, 37);
        txtName.TabIndex = 0;
        txtName.KeyPress += txtName_KeyPress;
        txtName.Validating += txtName_Validating;
        // 
        // guna2HtmlLabel1
        // 
        guna2HtmlLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2HtmlLabel1.BackColor = Color.Transparent;
        guna2HtmlLabel1.Location = new Point(375, 68);
        guna2HtmlLabel1.Name = "guna2HtmlLabel1";
        guna2HtmlLabel1.Size = new Size(80, 22);
        guna2HtmlLabel1.TabIndex = 3;
        guna2HtmlLabel1.Text = ":الصنف اسم";
        // 
        // guna2HtmlLabel2
        // 
        guna2HtmlLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2HtmlLabel2.BackColor = Color.Transparent;
        guna2HtmlLabel2.Location = new Point(375, 130);
        guna2HtmlLabel2.Name = "guna2HtmlLabel2";
        guna2HtmlLabel2.Size = new Size(78, 22);
        guna2HtmlLabel2.TabIndex = 4;
        guna2HtmlLabel2.Text = ":الصنف كود";
        // 
        // guna2HtmlLabel3
        // 
        guna2HtmlLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2HtmlLabel3.BackColor = Color.Transparent;
        guna2HtmlLabel3.Location = new Point(375, 193);
        guna2HtmlLabel3.Name = "guna2HtmlLabel3";
        guna2HtmlLabel3.Size = new Size(43, 22);
        guna2HtmlLabel3.TabIndex = 5;
        guna2HtmlLabel3.Text = ":السعر";
        // 
        // txtPrice
        // 
        txtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        txtPrice.BorderColor = Color.Gray;
        txtPrice.CustomizableEdges = customizableEdges3;
        txtPrice.DefaultText = "";
        txtPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        txtPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        txtPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        txtPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        txtPrice.Font = new Font("Segoe UI", 9F);
        txtPrice.ForeColor = Color.Black;
        txtPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        txtPrice.Location = new Point(202, 185);
        txtPrice.Margin = new Padding(3, 4, 3, 4);
        txtPrice.Name = "txtPrice";
        txtPrice.PasswordChar = '\0';
        txtPrice.PlaceholderText = "";
        txtPrice.SelectedText = "";
        txtPrice.ShadowDecoration.CustomizableEdges = customizableEdges4;
        txtPrice.Size = new Size(151, 37);
        txtPrice.TabIndex = 6;
        // 
        // txtProductNumber
        // 
        txtProductNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        txtProductNumber.BorderColor = Color.Gray;
        txtProductNumber.BorderRadius = 5;
        txtProductNumber.CustomizableEdges = customizableEdges5;
        txtProductNumber.DefaultText = "";
        txtProductNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        txtProductNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        txtProductNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        txtProductNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        txtProductNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        txtProductNumber.Font = new Font("Segoe UI", 9F);
        txtProductNumber.ForeColor = Color.Black;
        txtProductNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        txtProductNumber.Location = new Point(131, 124);
        txtProductNumber.Margin = new Padding(3, 4, 3, 4);
        txtProductNumber.Name = "txtProductNumber";
        txtProductNumber.PasswordChar = '\0';
        txtProductNumber.PlaceholderText = "";
        txtProductNumber.SelectedText = "";
        txtProductNumber.ShadowDecoration.CustomizableEdges = customizableEdges6;
        txtProductNumber.Size = new Size(222, 37);
        txtProductNumber.TabIndex = 7;
        txtProductNumber.KeyPress += txtProductNumber_KeyPress;
        txtProductNumber.Validating += txtProductNumber_Validating;
        // 
        // btnSave
        // 
        btnSave.Cursor = Cursors.Hand;
        btnSave.CustomizableEdges = customizableEdges7;
        btnSave.DisabledState.BorderColor = Color.DarkGray;
        btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
        btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        btnSave.FillColor = Color.CornflowerBlue;
        btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(102, 267);
        btnSave.Name = "btnSave";
        btnSave.ShadowDecoration.CustomizableEdges = customizableEdges8;
        btnSave.Size = new Size(251, 41);
        btnSave.TabIndex = 8;
        btnSave.Text = "حفظ";
        btnSave.Click += btnSave_Click;
        // 
        // errorProvider1
        // 
        errorProvider1.ContainerControl = this;
        // 
        // frmAddProduct
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(508, 363);
        Controls.Add(btnSave);
        Controls.Add(txtProductNumber);
        Controls.Add(txtPrice);
        Controls.Add(guna2HtmlLabel3);
        Controls.Add(guna2HtmlLabel2);
        Controls.Add(guna2HtmlLabel1);
        Controls.Add(txtName);
        FormBorderStyle = FormBorderStyle.SizableToolWindow;
        Name = "frmAddProduct";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "اضافة صنف";
        Load += frmAddProduct_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Guna.UI2.WinForms.Guna2TextBox txtName;
    private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    private Guna.UI2.WinForms.Guna2TextBox txtPrice;
    private Guna.UI2.WinForms.Guna2TextBox txtProductNumber;
    private Guna.UI2.WinForms.Guna2Button btnSave;
    private ErrorProvider errorProvider1;
}
