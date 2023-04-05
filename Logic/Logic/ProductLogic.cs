using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Logic.Logic
{
    public class ProductLogic : BaseContextLogic, IProductLogic
    {
        public ProductLogic(ServiceContext serviceContext) : base(serviceContext) { }

        public int AddProduct(ProductItem productItem)
        {
            _serviceContext.Products.Add(productItem);
            _serviceContext.SaveChanges();
            return productItem.Id;
        }

        public void DeactivateProduct(int id)
        {
            var productToDeactivate = _serviceContext.Set<ProductItem>()
           .Where(i => i.Id == id).First();

            productToDeactivate.IsActive = false;

            _serviceContext.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            _serviceContext.Products.Remove(_serviceContext.Set<ProductItem>().Where(i => i.Id == id).First());

            _serviceContext.SaveChanges();
        }

        public List<ProductItem> GetAllProduct()
        {
            return _serviceContext.Set<ProductItem>().ToList();
        }

        public List<ProductItem> GetProduct()
        {
            return _serviceContext.Set<ProductItem>().ToList();
        }

        //public List<ProductItem> GetProductByCriteria(ProductFilter productFilter)
        //{
        //    var resultList = _serviceContext.Set<ProductItem>()
        //                        .Where(p => p.IsActive == true);

        //    if (productFilter.InsertDateFrom != null)
        //    {
        //        resultList = resultList.Where(p => p.AddedDate > productFilter.InsertDateFrom);
        //    }

        //    if (productFilter.InsertDateTo != null)
        //    {
        //        resultList = resultList.Where(p => p.AddedDate < productFilter.InsertDateTo);
        //    }

        //    return resultList.ToList();
        //}


        public void UpdateProduct(ProductItem productItem)
        {
            _serviceContext.Products.Update(productItem);
            _serviceContext.SaveChanges();
        }
        List<ProductItem> IProductLogic.GetProductById(int id)
        {
            var selection = _serviceContext.Set<ProductItem>()
               .Where(i => i.Id == id).ToList();
            return selection;
        }
    }
}

