//using Data;
//using Entities.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Logic.ILogic
//{
//    public class SecurityLogic : ISecurityLogic
//    {
//        private readonly ServiceContext _serviceContext;
//        public SecurityLogic(ServiceContext serviceContext)
//        {
//            _serviceContext = serviceContext;
//        }
//        public bool ValidateUserCredentials(string userName, string userPassWord, int idRol)
//        {
//            var selectedUser = _serviceContext.Set<UserItem>()
//                                .Where(u => u.UserName == userName
//                                    && u.Password == userPassWord
//                                    && u.IdRol == idRol).FirstOrDefault();

//            if (selectedUser != null)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//    }
//}
