using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using MahdiShop.DataLayer.DataApi;
namespace MahdiShop.Core.Service
{
    public class ComputMony
    {
        private MahdiShop.DataLayer.Data.Context _context;
        public ComputMony(MahdiShop.DataLayer.Data.Context context)
        {
            _context = context;
        }
        public decimal ComputMonyToPay(string ListId)
        {
            List<String> d = ListId.Split(',').ToList();
            decimal mony = 0;
            foreach( int index in ListId){
              mony += new ProductApi().FindTheProductById(Convert.ToInt16(index)).Price;
            }
            return mony;
        }
    }
}
