using MahdiShop.Data.Models.Interface;
using MahdiShop.DataLayer.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MahdiShop.Data.Ripocitory
{
    internal class UserRipo : IUserRipo
    {
        private Context _context;
        UserRipo(Context context) { _context = context; }
        public bool AddUserToDb(User user)
        {
            //   _context.User.Add(user);
            // _context.saveChenge();
            throw new NotImplementedException();
        }

        public List<User> FilterTheUsers(string FilterItem)
        {
            throw new NotImplementedException();
        }

        public bool RemoveUserFromDb(int id)
        {
            //   _context.Remove.Add(id);
            // _context.saveChenge();
            throw new NotImplementedException();
        }

        public User searchUserByUserId(int id)
        {
            //  _context[_context.indexOf(id)];

            throw new NotImplementedException();
        }

        public bool UpDateUserinDb(User user)
        {
            //  _context[_context.indexOf(id)] = User;
            // _context.saveChenge();
            throw new NotImplementedException();
        }
    }
}
