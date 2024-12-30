using POS.Domain.Entities;

namespace POS.Application.Interface;

public interface IUserRepository : IRepository<User>
{
    public bool IsUserExist(string username);
}
