using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SALES_MVC.Models
{
    public class SellerFormViewModels
    {
        public Seller seller{ get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
