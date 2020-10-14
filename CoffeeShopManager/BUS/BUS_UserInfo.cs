using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_UserInfo
    {
        DAL_UserInfo dalUserInfo = new DAL_UserInfo();
        private string EncryptionPassword(string password)//mã hóa mật khẩu
        {
            return Encrypt(password, "haokute");
        }
        private string DecryptionPassword(string password)//giải mã mật khẩu
        {
            return Decrypt(password, "haokute");
        }
        private string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public bool CheckLogin(DTO_User account)
        {
            if (account.Email == "")
                return false;
            if (account.PassWord == "")
                return false;
            try
            {
                // account.Password = Encrypt(account.Password, "123");
                // return dalUserInfo.CheckLogin(account);
                DTO_User accountnew1=  dalUserInfo.GetByEmail(account.Email);
                account.PassWord = ComputeSha256Hash(account.PassWord);
                if (accountnew1 == null) return false;
                if (accountnew1.PassWord == account.PassWord)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool CheckUsername(string email)
        {
            if (email == "")
                return false;
            try
            {
                DTO_User accountnew1 = dalUserInfo.GetByEmail(email);
                if (accountnew1 == null) return true;
                return false;

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
                return dalUserInfo.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DTO_User GetByEmail(string email)
        {
            try
            {
                return dalUserInfo.GetByEmail(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Insert(DTO_User account)
        {
            try
            {
                if (CheckUsername(account.Email))
                {
                    //mã hóa trước khi insert;
                    account.PassWord = ComputeSha256Hash(account.PassWord);
                    dalUserInfo.Insert(account);
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(DTO_User account)
        {
            try
            {
                dalUserInfo.Delete(account);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(DTO_User account)
        {
            try
            {
                //mã hóa trước khi update
                account.PassWord = ComputeSha256Hash(account.PassWord);
                dalUserInfo.Update(account);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string Encrypt(string toEncrypt, string key)
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
        public static string Decrypt(string toDecrypt, string key)
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
