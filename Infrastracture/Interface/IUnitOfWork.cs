using MahdiShop.DataLayer.Polymorphis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahdiShop.Data.Models.Interface
{
    public interface IUnitOfWork
    {
        public IProductRepo ProductRepo { get;}
        public IUserRepo UserRepo { get; }

    }
}
