using Entities.Entities;
using Resources.RequestModels;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using API.Models.FilterModels;

namespace API.IServices
{
    public interface IProductService
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
