using System;

namespace OesUI.bean
{
    //used to save user information
    [Serializable]
    public class UserInfo
    {
        private string userName;
        private string password;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
