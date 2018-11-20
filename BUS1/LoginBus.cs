using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAO1;
using DTO;
namespace BUS1
{
    public class LoginBus
    {
        public bool Login(Account acc)
        {
            //DataProvider dp = new DataProvider();
            //return (dp.Login(user, pass));
            try
            {
                return new LoginDAO().Login(acc);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
    }
}
