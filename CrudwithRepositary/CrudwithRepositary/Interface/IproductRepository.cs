using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudwithRepositary.Interface
{
   public interface IproductRepository
    {
        Task<IEnumerable<product>> GetAll();
        Task<product> GetById(int id);
        Task Add(product model);
        Task Update(product model);
        Task Delete(int id);
    }
}
