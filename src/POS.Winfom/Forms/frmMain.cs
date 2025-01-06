using Mediator;
using POS.Application.Interface;
using POS.Application.Payment;
using POS.Application.Roles;

namespace POW.Winfom;

public partial class frmMain : Form
{
    readonly IMediator _mediator;
    public frmMain(IMediator mediator)
    {
        InitializeComponent();
        _mediator = mediator;
    }

    private void btnCloes_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
