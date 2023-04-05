using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IProductLogic
    {
        int AddProduct(ProductItem productItem);
        List<ProductItem> GetAllProduct();
        List<ProductItem> GetProduct();
        //List<ProductItem> GetProductByCriteria(ProductFilter productFilter);
        List<ProductItem> GetProductById(int id); 
        void DeactivateProduct(int id);
        void DeleteProduct(int id);
        void UpdateProduct(ProductItem productItem);
    }
}
