using DAL.EF.Context;
using Entities;

namespace DAL.EF
{
    public class UserRepository : Repository<User, int>
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }
    }
}
