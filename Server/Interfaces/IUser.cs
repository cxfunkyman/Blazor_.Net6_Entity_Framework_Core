using Blazor_.Net6_Entity_Framework_Core.Shared.Models;

namespace Blazor_.Net6_Entity_Framework_Core.Server.Interfaces
{
    public interface IUser
    {
        public List<User> GetUsersDetails();
        public void AddUser(User user);
        public void UpdateUserDetails(User user);
        public User GetUserData(int id);
        public void DeleteUser(int id);
    }
}
