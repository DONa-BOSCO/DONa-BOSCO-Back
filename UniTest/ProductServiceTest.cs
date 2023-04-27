using API.Services;
using Entities.Entities;



namespace MsTest
{
    [TestClass]
    public class ProductServiceTest
    {
        
        [TestMethod]
        public void ValidateModelTest()
        {
            // Arrange
            ProductItem productA = null;
            ProductItem productB = new ProductItem();
            productB.Id = 0;
            productB.IdPhotoFile = 1;
            productB.Title = "Sofá Vintage";
            productB.Description = "Sofá de los años 70, color negro y de dos plazas";
            productB.AddedDate = DateTime.Now;
            
            ProductItem productC = new ProductItem();
            productC.Id = 0;
            productC.IdPhotoFile = 0;
            productC.Title = "Entrenamiento intensivo de karate";
            productC.Description = "Evento de 3 días de entrenamiento de karate para aquellos que deseen mejorar sus habilidades y técnica";
            productC.AddedDate = DateTime.Now.AddDays(1000);
            
            // Act
            var productAIsValid = ProductService.ValidateModel(productA);
            var productBIsValid = ProductService.ValidateModel(productB);
            var productCIsValid = ProductService.ValidateModel(productC);
            //// Assert
            Assert.AreEqual(false, productAIsValid, "Custom error message");
            Assert.AreEqual(true, productBIsValid, "Custom error message");
            Assert.AreEqual(false, productCIsValid, "Custom error message");
        }
    }
    
}