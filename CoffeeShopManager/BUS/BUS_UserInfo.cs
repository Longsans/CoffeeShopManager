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
        private string connectionString;
        DAL_UserInfo dalUserInfo;

        public BUS_UserInfo(string connString)
        {
            connectionString = connString;
            dalUserInfo = new DAL_UserInfo(connectionString);
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
            if (account.Username == "")
                return false;
            if (account.PassWord == "")
                return false;
            try
            {
                DTO_User accountnew1=  dalUserInfo.GetByUsername(account.Username);
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
        public bool CheckUsername(string username)
        {
            if (username == "")
                return false;
            try
            {
                DTO_User accountnew1 = dalUserInfo.GetByUsername(username);
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

       
        public bool Insert(DTO_User account)
        {
            try
            {
                if (CheckUsername(account.Username))
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
        public DTO_User EncodePass(DTO_Manager dtoMan)
        {
            dtoMan.Account.PassWord = ComputeSha256Hash(dtoMan.Account.PassWord);
            return dtoMan.Account;
        }
        public DTO_User EncodePass(DTO_Employee dtoEmp)
        {
            dtoEmp.Account.PassWord = ComputeSha256Hash(dtoEmp.Account.PassWord);
            return dtoEmp.Account;
        }
    }
}
