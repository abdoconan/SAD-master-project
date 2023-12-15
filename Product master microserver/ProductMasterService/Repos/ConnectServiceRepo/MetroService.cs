using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMasterService
{
    public class MetroService : IConnectService
    {
        Task<List<ProductDTO>> IConnectService.getProduct()
        {
            throw new NotImplementedException();
        }

    }
}