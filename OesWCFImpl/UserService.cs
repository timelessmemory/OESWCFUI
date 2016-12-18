using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using OesWCFContract;
using System.Text;
using OesLogic;

namespace OesWCFImpl
{
    public class UserService : IUserService
    {

        public object queryUserIdByName(string name)
        {
            UserManager manager = new UserManager();
            return manager.queryUserIdByName(name);
        }

        public bool VerifyUserLogin(string username, string password)
        {
            try
            {
                UserManager manager = new UserManager();
                return manager.VerifyUserLogin(username, password);
            }
            catch (UserNameNotExistentException ex)
            {
                var e = new UserNameNotExistent();
                e.Messge = ex.Message;
                throw new FaultException<UserNameNotExistent>(e, new FaultReason(ex.Message));
            }
            catch (Exception)
            {
                throw new Exception("Unknown Exception");
            }
        }
    }
}
