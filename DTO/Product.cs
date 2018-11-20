using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public float Purchase { get; set; }
        public float SellingPrice { get; set; }
        public int CategoryId { get; set; }
        public string SupplierId { get; set; }
        public Product(string id, string name, float purchase, float sellingprice, int categoryid, string supplierid)
        {
            this.Id = id;
            this.Name = name;
            this.Purchase = purchase;
            this.SellingPrice = sellingprice;
            this.CategoryId = categoryid;
            this.SupplierId = supplierid;
        }
    }
}
