using DAL.EF.Context;
using DAL.Services.Interfaces;
using Entities;
using Filters;

namespace DAL.Services
{
    public class UserRepository : Repository<User, int, UserFilter>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        protected override IQueryable<User> FilterObjects(IQueryable<User> entities, UserFilter filter)
        {
            return entities;
        }
    }
}
