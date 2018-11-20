using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAO1;
using DTO;

namespace BUS1
{
    public class SupplierBus
    {
        SupplierDAO supDAO= new SupplierDAO();
        public List<Supplier> GetSupplier()
        {
            try
            {
                return supDAO.GetSupplier();
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
    }
}
