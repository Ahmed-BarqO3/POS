using POS.Domain.Entities;

namespace POS.Application.Stocks.Commands;

public record CreateStock(
    string ProductCode,
    decimal BuyUnitPrice,
    DateOnly Date,
    DateOnly? ReleaseDate,
    DateOnly? ExpireDate,
    short Quantity,
    decimal Total,
    byte CreatedBy
 ) : IRequest<bool>;

public class CraeteStockHandler : IRequestHandler<CreateStock, bool>
{
    private readonly IUnitOfWork _context;
    
    public CraeteStockHandler(IUnitOfWork context)
    {
        _context = context;
    }

    public  ValueTask<bool> Handle(CreateStock request, CancellationToken cancellationToken)
    {
        var s = request.Adapt<Stock>();
        _context.Stock.AddAsync(s);
        return ValueTask.FromResult(_context.Commite() > 0);
    }
}
