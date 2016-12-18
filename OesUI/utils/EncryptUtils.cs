using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace OesUI.utils
{
    public static class EncryptUtils
    {
        private static string LINE = "-";

        public static string EncryptPassword(string originalPassword)
        {
            MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(originalPassword);
            byte[] hashCode = Md5.ComputeHash(passwordBytes);
            return BitConverter.ToString(hashCode).Replace(LINE, Constants.EMPTY_STR);
        }
    }
}
