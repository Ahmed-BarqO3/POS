using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mediator;
using POS.Application.Interface;
using POS.Application.Product.Qury;

namespace POW.Winfom.Forms.Products;
public partial class frmShowProduct : Form
{
    private readonly IMediator _mediator;

    public frmShowProduct(IMediator mediator)
    {
        InitializeComponent();
        _mediator = mediator;
    }

    void _RefrechProducts()
    {
        dgvProducts.DataSource = _mediator.Send(new GetAllProducts());
    }

    private void frmShowProduct_Load(object sender, EventArgs e)
    {
        txtSearch.Focus();
        _RefrechProducts();

    }
}
