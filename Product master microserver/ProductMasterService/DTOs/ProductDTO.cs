using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMasterService
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
        public string Vendor { get; set; }
    }
}