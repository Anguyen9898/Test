using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;

namespace DAO1
{
    public class SupplierDAO:DataProvider
    {
        public List<Supplier> GetSupplier()
        {
            try
            {
                string sql = "SELECT * FROM Supplier";
                string id, name;
                List<Supplier> list = new List<Supplier>();
                Connect();
                //SqlDataReader dr = new SqlDataReader();
                SqlDataReader dr = myExcuteReder(sql);
                while (dr.Read())
                {
                    id = dr[0].ToString();
                    name = dr[1].ToString();
                    Supplier sup = new Supplier(id, name);
                    list.Add(sup);
                }
                dr.Close();
                return list;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
    }
}
