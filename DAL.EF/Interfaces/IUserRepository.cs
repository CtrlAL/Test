using Entities;
using Filters;

namespace DAL.EF.Interfaces
{
    public interface IUserRepository : IRepository<User, int, UserFilter>
    {
    }
}
