using DAL.EF.Context;
using DAL.EF.Interfaces;
using Entities;

namespace DAL.EF
{
    public class UserRepository : Repository<User, int>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }
    }
}
