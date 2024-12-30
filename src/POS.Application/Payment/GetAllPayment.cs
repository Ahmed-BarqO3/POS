namespace POS.Application.Payment;

public class GetAllPayment: IRequest<List<PaymentReponse>>
{
    
}
public class GetAllPaymentHandler : IRequestHandler<GetAllPayment, List<PaymentReponse>>
{
    private readonly IUnitOfWork _context;

    public GetAllPaymentHandler(IUnitOfWork context)
    {
        _context = context;
    }

    public async ValueTask<List<PaymentReponse>> Handle(GetAllPayment request, CancellationToken cancellationToken)
    {
        var payments = await _context.PaymentMethod.GetAllAsync();
        return payments.Adapt<List<PaymentReponse>>();
    }
}
