using POS.Application.Interface;
using POS.Domain.Entities;
using POS.Infastructure.Data;

namespace POS.Infastructure.Repositories;

public class UserRepositorie : Repository<User>, IUserRepository
{
    readonly AppDbcontext _context;
    public UserRepositorie(AppDbcontext context) : base(context)
    {
        _context = context;
    }

    public bool IsUserExist(string username)
    {
        return _context.Set<User>().Any(x => x.Username == username);
    }
}
