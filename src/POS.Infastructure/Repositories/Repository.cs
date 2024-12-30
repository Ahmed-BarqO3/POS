using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using POS.Infastructure.Data;

namespace POS.Infastructure.Repositories;

using POS.Application.Interface;
public class Repository<T> : IRepository<T> where T : class, new()
{
    readonly AppDbcontext _context;
    public Repository(AppDbcontext context)
    {
        _context = context;
    }
    
    public Task<List<T>> GetAllAsync(string[]? includes = null, CancellationToken? ct = null)
    {
        IQueryable<T> qury = _context.Set<T>();
        
        if(includes is not null)
            foreach (var include in includes)
            {
                qury = qury.Include(include);
            }

        return qury.ToListAsync(ct ?? CancellationToken.None);
    }

    public ValueTask<T?> GetByIdAsync(int id) =>
    
        _context.Set<T>().FindAsync(id);
    
    public Task AddAsync(T entity) =>
        
        Task.FromResult(_context.Set<T>().AddAsync(entity));
    
    public void AddRange(List<T> entities) =>
    
        _context.Set<T>().AddRange(entities);


    public Task Update(T entity) =>

        Task.FromResult(_context.Set<T>().Update(entity));


    public Task Delete(T entity) =>

        Task.FromResult(_context.Set<T>().Remove(entity));

    public Task<T?> FindAsync(Expression<Func<T, bool>> predicate, string[]? includes = null, CancellationToken? ct = null)
    {
        IQueryable<T> qury = _context.Set<T>();
        
        if(includes is not null)
            foreach (var include in includes)
            {
                qury =  qury.Include(include);
            }

        return qury.FirstOrDefaultAsync(predicate);
    }
    
    public Task<List<T>> FindAllAsync(Expression<Func<T, bool>> predicate, string[]? includes = null,
        CancellationToken? ct = null)
    {
        IQueryable<T> qury = _context.Set<T>().Where(predicate);
        
        if(includes is not null)
            foreach (var include in includes)
            {
               qury =  qury.Include(include);
            }

        return qury.ToListAsync(ct ?? CancellationToken.None);
    }

    public Task<List<T>> GetByExecuteStoredProc(FormattableString commandName) =>
    
        _context.Set<T>().FromSql(commandName).ToListAsync();

    public  Task<T?> ExecuteStoredProcTask(string commandName) =>

        Task<T?>.FromResult(_context.Set<T>().FromSqlRaw(commandName).AsEnumerable().FirstOrDefault());

}
