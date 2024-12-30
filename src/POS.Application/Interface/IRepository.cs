using System.Linq.Expressions;

namespace POS.Application.Interface;
public interface IRepository<T> where T : class, new()
{
    Task<List<T>> GetAllAsync(string[]? includes = null,CancellationToken?ct = null);
    ValueTask<T?> GetByIdAsync(int id);
    Task AddAsync(T entity);
    void AddRange(List<T> entities);
    Task Update(T entity);
    Task Delete(T id);
    Task<T?> FindAsync(Expression<Func<T, bool>> predicate,string[]? includes = null,CancellationToken? ct = null);
    Task<List<T>> FindAllAsync(Expression<Func<T, bool>> predicate, string[]? includes = null,CancellationToken? ct = null);
    Task<List<T>> GetByExecuteStoredProc(FormattableString commandName);
    Task<T> ExecuteStoredProcTask(string commandName);
}
