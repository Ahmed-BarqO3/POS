using POS.Application.Common;
using POS.Domain.Entities;

namespace POS.Application.Invoice.Commands;

public class CreateInvoice : IRequest<bool>
{
    public CreateInvoice(List<InvoiceDetail> Products,decimal discount,byte createdBy, byte paymentMethod)
    {
        InvoiceDetails = Products;
        Discount = discount;
        CreatedBy = createdBy;
        PaymentMethod = paymentMethod;
    }
   
    public readonly DateTime Date = DateTime.Now;
    public readonly List<InvoiceDetail> InvoiceDetails;
    public readonly byte CreatedBy;
    public readonly byte PaymentMethod;
    public decimal Discount { get; set;}
    public decimal Total  =>  InvoiceDetails.Select(x => x.Quantity * x.ProductCodeNavigation.UnitPrice).Sum() - Discount;
}

public class CreateIvoiceHandler : IRequestHandler<CreateInvoice, bool>
{
    readonly IUnitOfWork _unitOfWork;

    public CreateIvoiceHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public ValueTask<bool> Handle(CreateInvoice request, CancellationToken cancellationToken)
    {
        string INV = Utility.GenerateInvoiceNumber(request.CreatedBy.ToString());
        var invice = new Domain.Entities.Invoice
        {
             InvoiceId = INV,
             Date = request.Date,
             Discount = request.Discount,
             CreatedBy = request.CreatedBy,
             PaymenyMethod = request.PaymentMethod,
             Total = request.Total,
        };
         request.InvoiceDetails.Select(x => x.InvoiceId = INV).ToList();
        _unitOfWork.InvoiceDetail.AddRange(request.InvoiceDetails);
        _unitOfWork.Invoice.AddAsync(invice);
         return  ValueTask.FromResult(_unitOfWork.Commite() > 0);
    }
}
 
