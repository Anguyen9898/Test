using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAO1;
using DTO;
namespace BUS1
{
    public class ProductBus
    {
        ProductDAO proDao = new ProductDAO();
        public List<Product> GetProduct()
        {
            try
            {
                return proDao.GetProduct();
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
        public int Add(Product pro)
        {
            try
            {
                return proDao.Add(pro);
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
    }
}
