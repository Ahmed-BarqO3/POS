namespace POS.Application.Product.Qury;

public class GetAllProducts : IRequest<List<ProductResponse>>
{
    
}

public class GetAllProductsHandler : IRequestHandler<GetAllProducts, List<ProductResponse>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetAllProductsHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<List<ProductResponse>> Handle(GetAllProducts request, CancellationToken cancellationToken)
    {
        var result = await _unitOfWork.Product.GetAllAsync(ct: cancellationToken);
        return result.Adapt<List<ProductResponse>>();
    }
}
