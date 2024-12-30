namespace POS.Application.Product.Command;

public record CreateProduct : IRequest<bool>
{
    string ProductCode { get; init; }
    string Name { get; init; }
    decimal Price { get; init; }
}

public class CreateProductHandler : IRequestHandler<CreateProduct, bool>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateProductHandler(IUnitOfWork productRepository)
    {
        _unitOfWork = productRepository;
    }

    public  ValueTask<bool> Handle(CreateProduct request, CancellationToken cancellationToken)
    {
        var p = request.Adapt<Domain.Entities.Product>();
        _unitOfWork.Product.AddAsync(p);
        return ValueTask.FromResult(_unitOfWork.Commite() > 0);
    }
}
