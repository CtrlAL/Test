using Entities;
using Filters;

namespace DAL.Services.Interfaces
{
    public interface IUserRepository : IRepository<User, int, UserFilter>
    {
    }
}
