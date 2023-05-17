using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MahdiShop.Data.Models.Interface;
namespace MahdiShop.Core.Service
{
    public class ComputMony
    {
        private readonly IUnitOfWork _unitOfWork;
        public ComputMony(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public decimal ComputMonyToPay(string ListId)
        {
            List<String> d = ListId.Split(',').ToList();
            decimal mony = 0;
            foreach( int index in ListId){
              mony += _unitOfWork.ProductRepo.GetById(Convert.ToInt32(index)).Price;
            }
            return mony;
        }
    }
}
