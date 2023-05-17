using MahdiShop.Data.Models.Interface;
using MahdiShop.Data.Ripocitory;
using MahdiShop.DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahdiShop.Core.UnitOfWork
{

    public class UnitOfWork : IUnitOfWork
    {
        private IProductRepo _productRepo;
        private IUserRepo _userRepo;
        private readonly Context _context;
        public UnitOfWork(Context context)
        {
            _context = context;
        }

        public IProductRepo ProductRepo
        {
            get
            {
                if (_productRepo == null)
                    _productRepo = new ProductRepo(_context);
                return _productRepo;
            }
        }
        public IUserRepo UserRepo 
        {
            get
            {
                if (_userRepo == null)
                    _userRepo = new UserRepo(_context);
                return _userRepo;
            }
        }
    }
}
