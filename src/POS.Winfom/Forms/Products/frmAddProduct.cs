using System;
using System.ComponentModel;
using Mediator;
using POS.Application.Product.Command;
using POS.Application.Product.Qury;

namespace POW.Winfom.Forms.Products;
public partial class frmAddProduct : Form
{
    enum Mode { Add, Update };

    readonly Mode _mode;
    readonly string? _productNumebr;
    readonly IMediator _mediator;
    IRequest<bool> _request;

    public frmAddProduct(IMediator mediator)
    {
        InitializeComponent();
        _mode = Mode.Add;
        _mediator = mediator;
    }

    public frmAddProduct(string ProductNumebr, IMediator mediator)
    {
        InitializeComponent();
        _mode = Mode.Update;
        _productNumebr = ProductNumebr;
        _mediator = mediator;
    }




    private void txtName_KeyPress(object sender, KeyPressEventArgs e)
    {
    }

    private void txtProductNumber_KeyPress(object sender, KeyPressEventArgs e)
    {

        if (e.Handled = char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            errorProvider1.SetError(txtProductNumber, "يجب ان يحتوي على ارقام فقط");
        else
            errorProvider1.SetError(txtProductNumber, "");
    }

    private void txtProductNumber_Validating(object sender, CancelEventArgs e)
    {
        if (String.IsNullOrEmpty(txtProductNumber.Text))
        {
            errorProvider1.SetError(txtProductNumber, "كود الصنف لايجب ان يكون فارغ");
        }
        else
        {
            errorProvider1.SetError(txtProductNumber, "");
        }
    }

    private void txtName_Validating(object sender, CancelEventArgs e)
    {
        if (String.IsNullOrEmpty(txtName.Text))
            errorProvider1.SetError(txtName, "اسم الصنف لايجب ان يكون فارغ");
        else
            errorProvider1.SetError(txtName, "");
    }

    private async void frmAddProduct_Load(object sender, EventArgs e)
    {
        if (_mode is Mode.Add)
            this.Text = "اضافة صنف";
        else if (_mode is Mode.Update)
        {

            var product = await _mediator.Send(new GetProduct(_productNumebr));
            this.Text = "تعديل صنف";
            txtName.Text = product.Name;
            txtProductNumber.Text = product.ProductCode;
            txtPrice.Text = product.UnitPrice.ToString();
        }
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (_mode is Mode.Add)
            _request = new CreateProduct(txtProductNumber.Text, txtName.Text, decimal.Parse(txtPrice.Text),0);
        else if (_mode is Mode.Update)
            _request = new UpdateProduct(txtProductNumber.Text, txtName.Text, decimal.Parse(txtPrice.Text),0);

        await _mediator.Send(_request);
        this.Close();
    }
}
