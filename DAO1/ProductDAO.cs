using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;

namespace DAO1
{
    public class ProductDAO:DataProvider
    {
        public List<Product> GetProduct()
        {
            string sql = "SELECT * FROM Product";
            string id, name, supplier;
            int categoryid;
            float purchase, sellingprice;
            List<Product> list = new List<Product>();
            try
            {
                Connect();
                //SqlDataReader dr = new SqlDataReader();
                SqlDataReader dr = myExcuteReder(sql);
                while (dr.Read())
                {
                    id = dr[0].ToString();
                    name = dr[1].ToString();
                    purchase = float.Parse(dr[2].ToString());
                    sellingprice = float.Parse(dr[3].ToString());
                    categoryid = int.Parse(dr[4].ToString());
                    supplier = dr[5].ToString();
                    Product pro = new Product(id, name, purchase, sellingprice, categoryid, supplier);
                    list.Add(pro);
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
        public int Add(Product pro)
        {
            string sql = "INSERT INTO Product VALUES()";
            try
            {
                return myExcuteNonQuery(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
