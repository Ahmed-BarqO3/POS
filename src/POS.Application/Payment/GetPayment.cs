namespace POS.Application.Payment;

public class GetPayment : IRequest<PaymentReponse>
{
    public GetPayment(byte id)
    {
        Id = id;
    }
    public  byte Id { get; }
}    

public class GetPaymentHandler : IRequestHandler<GetPayment,PaymentReponse>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetPaymentHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<PaymentReponse> Handle(GetPayment request, CancellationToken cancellationToken)
    {
        var p =  await _unitOfWork.PaymentMethod.FindAsync(x => x.Id == request.Id);
        return p.Adapt<PaymentReponse>();
    }
}

