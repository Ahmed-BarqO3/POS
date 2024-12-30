namespace POS.Application.Product.Command;

public record UpdateProduct(string ProductCode,string Name,decimal Price) : IRequest<bool>;

public class UpdateProductHandler : IRequestHandler<UpdateProduct, bool>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdateProductHandler(IUnitOfWork productRepository)
    {
        _unitOfWork = productRepository;
    }

    public  ValueTask<bool> Handle(UpdateProduct request, CancellationToken cancellationToken)
    {
        var p = request.Adapt<Domain.Entities.Product>();
        _unitOfWork.Product.Update(p);
        return ValueTask.FromResult(_unitOfWork.Commite() > 0);
    }
}
