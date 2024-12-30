namespace POS.Application.Stocks.Qury;
public record GetAllStock() : IRequest<List<StockResponse>>;

public class GetAllStockHandler : IRequestHandler<GetAllStock, List<StockResponse>>
{
    private readonly IUnitOfWork _stockRepository;

    public GetAllStockHandler(IUnitOfWork stockRepository)
    {
        _stockRepository = stockRepository;
    }

    public  async ValueTask<List<StockResponse>> Handle(GetAllStock request, CancellationToken cancellationToken)
    {
        var s = await  _stockRepository.Stock.GetAllAsync(ct: cancellationToken);
        return s.Adapt<List<StockResponse>>();
    }
}
