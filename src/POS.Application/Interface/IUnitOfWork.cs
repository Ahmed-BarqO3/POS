using POS.Domain.Entities;

namespace POS.Application.Interface;

public interface IUnitOfWork : IDisposable
{
    IRepository<Domain.Entities.Invoice> Invoice { get; }
    IRepository<InvoiceDetail> InvoiceDetail { get; }
    IRepository<PaymentMethod> PaymentMethod { get; }
    IRepository<Domain.Entities.Product> Product { get; }
    IRepository<Return> Return { get; }
    IRepository<Role> Role { get; }
    IUserRepository User { get; }
    IRepository<Stock> Stock { get; }
    IRepository<StockDamaged> StockDamaged { get; }
    
    int Commite();
}
