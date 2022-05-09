using Years.Models;

namespace Years.Interfaces
{
    public interface IUserRepository
    {
        void Insert(User user);
        IQueryable<User> GetPeople();
        IQueryable<User> GetTodayPeople();
    }
}
