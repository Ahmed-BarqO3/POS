using POS.Domain.Entities;

namespace POS.Application.Stocks.Commands;

public record UpdateStock(

    string ProductCode,
    decimal BuyUnitPrice,
    DateOnly Date,
    DateOnly? ReleaseDate, DateOnly? ExpireDate,
    short Quantity,
    decimal Total,
    byte CreatedBy
) : IRequest<bool>;

public class UpdateStockHandler : IRequestHandler<UpdateStock, bool>
{
    private readonly IUnitOfWork _context;

    public UpdateStockHandler(IUnitOfWork context)
    {
        _context = context;
    }

    public ValueTask<bool> Handle(UpdateStock request, CancellationToken cancellationToken)
    {
        var s = request.Adapt<Stock>();
        _context.Stock.Update(s);
        return ValueTask.FromResult(_context.Commite() > 0);
    }
}
