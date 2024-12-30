namespace POS.Application.Responses;

public record StockResponse(
    int StockId,
    string ProductCode,
    decimal BuyUnitPrice,
    DateOnly Date,
    DateOnly? ReleaseDate,
    DateOnly? ExpireDate,
    short Quantity,
    decimal Total,
    byte CreatedBy,
    UserResponse CreatedByNavigation,
    ProductResponse ProductCodeNavigation);
