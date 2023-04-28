
using API.Services;
using Entities.Entities;
using Logic.Logic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSTest
{
    [TestClass]
    public class UserItemTest
    {


        public readonly UserLogic _userLogic;
        [TestMethod]
        public void UserItem_Constructor_IsActiveTrue()
        {
            // Arrange
            var userItem = new UserItem();

            userItem.IdRol = 1;
            userItem.UserName = "vero30@hotmail.com";
            
            userItem.IsActive = true;
          
            // Assert
            Assert.IsTrue(userItem.IsActive);
        }
        [TestMethod]
        public void ValidateModelTest()
        {
            // Arrange

            UserItem usuarioA = null;
            UserItem usuarioB = new UserItem();
            usuarioB.IdRol = 0;
            usuarioB.UserName = "magda17@hotmail.com";
            usuarioB.InsertDate = DateTime.Now;

            UserItem usuarioC = new UserItem();
            usuarioC.IdRol = 0;

            usuarioC.UserName = "rocio34@gmail.com";

            usuarioC.InsertDate = DateTime.Now.AddDays(1000);

            // Act
            var usuarioAIsValid = UserService.ValidateModel(usuarioA);
            var usuarioBIsValid = UserService.ValidateModel(usuarioB);
            var usuarioCIsValid = UserService.ValidateModel(usuarioC);
            //// Assert
            Assert.AreEqual(false, usuarioAIsValid, "Custom error message");
            Assert.AreEqual(true, usuarioBIsValid, "Custom error message");
            Assert.AreEqual(true, usuarioCIsValid, "Custom error message");


         
        }
        [TestMethod]
        public void UserItem_EncryptedPassword_IsNotMappedToDatabase()
        {
            // Arrange
            var userItem = new UserItem();
            var EncryptedPassword = "mypassword";
            // Act
            userItem.EncryptedPassword = EncryptedPassword;
            // Assert
            Assert.IsNull(userItem.GetType().GetProperty("EncryptedPassword").GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault());
            Assert.AreEqual(EncryptedPassword, userItem.EncryptedPassword);
        }
       
    }
}

