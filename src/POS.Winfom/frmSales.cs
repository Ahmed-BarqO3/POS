using Mediator;
using POS.Application.Interface;
using POS.Application.Payment;
using POS.Application.Roles;

namespace POW.Winfom;

public partial class frmSales : Form
{
    readonly IMediator _mediator;
    public frmSales(IMediator mediator)
    {
        InitializeComponent();
        _mediator = mediator;
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        var r = await _mediator.Send(new GetPayment(1));
        MessageBox.Show(r.Name);
       
    }
}
