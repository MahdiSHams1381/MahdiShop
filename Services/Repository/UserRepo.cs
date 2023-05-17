using MahdiShop.Data.Models.Interface;
using MahdiShop.DataLayer.Data;
using MahdiShop.DataLayer.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahdiShop.Data.Ripocitory
{
    public class UserRepo : IUserRepo
    {
        private Context _context;
        public UserRepo(Context context) { _context = context; }
        public bool AddUserToDb(User user)
        {
            try
            {
                _context.User.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public List<User> FilterTheUsers(string FilterItem)
        {
            throw new NotImplementedException();
        }

        public bool RemoveUserFromDb(int id)
        {
            try
            {
                _context.User.Remove(searchUserByUserId(id));
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public User searchUserByUserId(int id)
        {
            return _context.User.FirstOrDefault(x => x.UserId == id);

        }

        public bool UpDateUserinDb(User user)
        {
            try
            {
                var old_User = searchUserByUserId(user.UserId);
                old_User.UserPhone = user.UserPhone;
                old_User.UserEmail = user.UserEmail;
                old_User.UserName = user.UserName;
                old_User.PasswordRip = user.PasswordRip;
                old_User.Password = user.Password;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
