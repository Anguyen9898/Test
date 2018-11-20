using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAO1;
using DTO;
namespace DAO1
{
    public class LoginDAO:DataProvider
    {
        public bool Login(Account acc)
        {
            string sql = "SELECT COUNT * FROM Users WHERE UserName= '" + acc.UserName + "' AND Password= '" + acc.PassWord + "'";
            int number;
            try
            {
                number = myExcuteScalar(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            if (number > 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
