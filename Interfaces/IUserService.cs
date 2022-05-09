using Years.Models;
using Years.ViewModels.User;

namespace Years.Interfaces
{
    public interface IUserService
    {
        void Insert(User user);
        ListUserViewModel GetPeople();
        ListUserViewModel GetTodayPeople();
    }
}
