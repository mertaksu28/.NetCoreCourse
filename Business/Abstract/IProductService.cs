using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GetList();
        List<Product> GetListByProduct(int categoryId);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }
}
