using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface IProductRepository
    {
        public IEnumerable<Product> FilterProductList(string name);
        public IEnumerable<Product> GetProductList();
        public Product GetProductById(int id);
        public void AddProduct(Product _Product);
        public void UpdateProduct(Product _Product);
        public void RemoveProduct(Product _Product);
    }
}
