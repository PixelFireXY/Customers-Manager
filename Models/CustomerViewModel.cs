using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersManager.Models
{
    public class CustomerViewModel
    {
        public List<Customer> Customers { get; set; }
        public SelectList Province { get; set; }
        public string CustomerProvince { get; set; }
        public string SearchString { get; set; }
    }
}
