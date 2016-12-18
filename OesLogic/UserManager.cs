using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OesDAL.UserDSTableAdapters;

namespace OesLogic
{
    public class UserManager
    {
        private const int onlyOneRecord = 1;
        /// <summary>
        /// Verify user login
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="password">passsword</param>
        /// <returns>is login success</returns>
        public bool VerifyUserLogin(string username, string password)
        {
            UsersTableAdapter userAdapter = new UsersTableAdapter();
            int? userNameCheck = userAdapter.VerifyUserName(username);

            if (!userNameCheck.HasValue || userNameCheck.Value != onlyOneRecord)
            {
                throw new UserNameNotExistentException();
            }

            int? result = userAdapter.VerifyLogin(username, password);
            return result.HasValue && result.Value == onlyOneRecord;
        }

        public Object queryUserIdByName(string name)
        {
            UsersTableAdapter userAdapter = new UsersTableAdapter();
            return userAdapter.QueryUserIdByName(name);
        }
    }
}
