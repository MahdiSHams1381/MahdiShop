using MahdiShop.DataLayer.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahdiShop.Data.Models.Interface
{
    public interface IUserRepo
    {
        bool AddUserToDb(User user);
        bool RemoveUserFromDb(int id);
        bool UpDateUserinDb(User user);
        User searchUserByUserId(int id);
        List<User> FilterTheUsers(String FilterItem);
    }
}
