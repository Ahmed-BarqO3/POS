namespace POS.Application.Responses;

public record InvoiceDetailResponse(long Id, string ProductCode, DateTime Date, short Quantity, string InvoiceId, bool IsReturn, InvoiceResponse Invoice, ProductResponse Product);
