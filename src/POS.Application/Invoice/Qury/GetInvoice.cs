namespace POS.Application.Invoice.Qury;

public record GetInvoice(string InvoiceID) : IRequest<InvoiceResponse>;

public class GetInvoiceHandler : IRequestHandler<GetInvoice, InvoiceResponse>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetInvoiceHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public  async ValueTask<InvoiceResponse> Handle(GetInvoice request, CancellationToken cancellationToken)
    {
        var invoice = await _unitOfWork.Invoice.FindAsync(x => x.InvoiceId == request.InvoiceID);
        return invoice.Adapt<InvoiceResponse>();
    }
}
