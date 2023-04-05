using API.IServices;
using Entities.Entities;
using Logic.ILogic;
using Resources.RequestModels;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Models.FilterModels;
using Data;

namespace API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductLogic _productLogic;
        private readonly ServiceContext _serviceContext;
        public ProductService(ServiceContext serviceContext, IProductLogic productLogic)
        {
            _serviceContext = serviceContext;
            _productLogic = productLogic;
        }

        void IProductService.DeactivateProduct(int id)
        {
            _productLogic.DeactivateProduct(id);
        }


        public void DeleteProduct(int id)
        {
            _productLogic.DeleteProduct(id);
        }

        public List<ProductItem> GetAllProduct()
        {
            return _productLogic.GetAllProduct();
        }

        public List<ProductItem> GetProduct()
        {
            return _productLogic.GetProduct();
        }
        public List<ProductItem> GetProductById(int id)
        {
            return _productLogic.GetProductById(id);
        }

        public void UpdateProduct(ProductItem productItem)
        {
            _productLogic.UpdateProduct(productItem);
        }

        int IProductService.AddProduct(ProductItem productItem)
        {
            _serviceContext.Products.Add(productItem);
            _serviceContext.SaveChanges();
            return productItem.Id;
        }
    }
}
