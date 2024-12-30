using POS.Application.Interface;
using POS.Domain.Entities;
using POS.Infastructure.Data;
using POS.Infastructure.Repositories;

namespace POS.Infastructure;

public class UnitOfWork : IUnitOfWork
{
    readonly AppDbcontext _context;

    public UnitOfWork(AppDbcontext context)
    {
        _context = context;
        Invoice = new Repository<Invoice>(_context);
        InvoiceDetail = new Repository<InvoiceDetail>(_context);;
        PaymentMethod = new Repository<PaymentMethod>(_context);;
        Product = new Repository<Product>(_context);;
        Return = new Repository<Return>(_context);;
        Role = new Repository<Role>(_context);;
        User = new UserRepositorie(_context);;
        Stock = new Repository<Stock>(_context);;
        StockDamaged = new Repository<StockDamaged>(_context);;
    }
    public IRepository<Invoice> Invoice { get; }
    public IRepository<InvoiceDetail> InvoiceDetail { get; }
    public IRepository<PaymentMethod> PaymentMethod { get; }
    public IRepository<Product> Product { get; }
    public IRepository<Return> Return { get; }
    public IRepository<Role> Role { get; }
    public IUserRepository User { get; }
    public IRepository<Stock> Stock { get; }
    public IRepository<StockDamaged> StockDamaged { get; }
    
    public int Commite() =>

        _context.SaveChanges();
    
    public void Dispose() =>
    
        _context.Dispose();
}
