namespace POS.Application.Responses;

public record InvoiceResponse
    (
    string InvoiceId,
    DateTime Date,
    decimal? Discount,
    decimal Total,
    byte CreatedBy,
    byte PaymenyMethod,
    UserResponse CreatedByNavigation,
    PaymentReponse PaymenyMethodNavigation);
