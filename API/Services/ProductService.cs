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

        public List<ProductItem> GetProductsByUserId(int userId)
        {
            return _productLogic.GetProductsByUserId(userId);
        }

        public int InsertProduct(ProductItem productItem)
        {
            if (!ValidateModel(productItem))
            {
                throw new InvalidDataException();
            }
            _productLogic.InsertProduct(productItem);
            if (!ValidateInsertedProduct(productItem))

            {
                throw new InvalidOperationException();
            }
            return productItem.Id;
        }

        public static bool ValidateModel(ProductItem productItem)
        {

            if (productItem == null)
            {
                return false;
            }
            if (productItem.IdPhotoFile < 1)
            {
                return false; ;
            }
            if (productItem.Title == null || productItem.Title == "")
            {
                return false; ;
            }
            if (productItem.Description == null || productItem.Description == "")
            {
                return false; ;
            }
            if (productItem.AddedDate > DateTime.Now)
            {
                return false; ;
            }
            return true;
        }

        public static bool ValidateInsertedProduct(ProductItem productItem)
        {
            if (!ValidateModel(productItem))

            {
                return false;
            }
            if (productItem.Id < 1)
            {
                return false;
            }
            return true;
        }
    }
}
