using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_UserInfo
    {
        DAL_UserInfo dalUserinfo = new DAL_UserInfo();
        public string EncryptionPassword(string password)//Mã hóa mk
        {
            return Encrypt(password, "haokute");
        }
        public string DecryptionPassword(string password)//Giải mã mk
        {
            return Decrypt(password, "haokute");
        }
        public bool CheckLogin(DTO_User account)
        {
            if (account.Email == "")
                return false;
            if (account.PassWord == "")
                return false;
            try
            {
                // return dalUserinfo.CheckLogin(account);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DTO_User GetById(int id)
        {
            try
            {
                return dalUserinfo.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DTO_User GetByEmail(string email)
        {
            return dalUserinfo.GetByEmail(email);
        }
        public void Insert (DTO_User user)
        {
            try
            {
               // user.PassWord = Encrypt(user.PassWord, "123");//ma hoa mat khau
                dalUserinfo.Insert(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(DTO_User user)
        {
            try
            {
                dalUserinfo.Delete(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(DTO_User user)
        {
            try
            {
               // user.PassWord = Encrypt(user.PassWord, "123");//Cường coi mã hóa 2 lần 1 mật khẩu
                dalUserinfo.Update(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string Encrypt(string toEncrypt, string key)//Mã hóa mk
        {
            bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        public static string Decrypt(string toDecrypt, string key)//Giải mã mk
        {
            bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}
