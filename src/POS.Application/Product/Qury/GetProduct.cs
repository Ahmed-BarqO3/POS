namespace POS.Application.Product.Qury;

public class GetProduct : IRequest<ProductResponse>
{
    public GetProduct(string productCode)
    {
        ProductCode = productCode;
    }
    public string ProductCode { get; }
}

public class GetProductHandler : IRequestHandler<GetProduct, ProductResponse>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetProductHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public  async ValueTask<ProductResponse> Handle(GetProduct request, CancellationToken cancellationToken)
    {
        var p = request.Adapt<Domain.Entities.Product>();
        var result =  await _unitOfWork.Product.FindAsync(x => x.ProductCode == p.ProductCode);
        return result.Adapt<ProductResponse>();
    }
}
