using Blazor_.Net6_Entity_Framework_Core.Server.Interfaces;
using Blazor_.Net6_Entity_Framework_Core.Server.Models;
using Blazor_.Net6_Entity_Framework_Core.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_.Net6_Entity_Framework_Core.Server.Services
{
    public class UserManager : IUser
    {
        readonly DatabaseContext _dbContext = new ();

        public UserManager(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        //Get all the details of the user
        public List<User> GetUsersDetails()
        {
            try
            {
                return _dbContext.Users.ToList();
            }
            catch //(Exception e)
            {
                //Console.WriteLine(e);
                throw;
            }
        }
        //To add new user
        public void AddUser(User user)
        {
            try
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
            }
            catch //(Exception e)
            {
                //Console.WriteLine(e);
                throw;
            }
        }
        //To update the records of user
        public void UpdateUserDetails(User user)
        {
            try
            {
                _dbContext.Entry(user).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch //(Exception e)
            {
                //Console.WriteLine(e);
                throw;
            }
        }
        //Get the details of user
        public User GetUserData(int id)
        {
            try
            {
                User? user = _dbContext.Users.Find(id);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch //(Exception e)
            {
                //Console.WriteLine(e);
                throw;
            }
        }
        // Delete record of user
        public void DeleteUser(int id)
        {
            try
            {
                User? user = _dbContext.Users.Find(id);

                if (user != null)
                {
                    _dbContext.Users.Remove(user);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch //(Exception e)
            {
                //Console.WriteLine(e);
                throw;
            }
        }
    }
}
