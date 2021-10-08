using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId=1, CategoryId=1, ProductName="bardak", UnitPrice=15, UnitsInStock=10},
                new Product{ProductId=2, CategoryId=1, ProductName="tabak", UnitPrice=4, UnitsInStock=2},
                new Product{ProductId=3, CategoryId=2, ProductName="kupa", UnitPrice=7, UnitsInStock=8},
                new Product{ProductId=4, CategoryId=2, ProductName="termos", UnitPrice=5, UnitsInStock=12}

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        //LINQ - Language Integrated Query - foreach yerine 
        public void Delete(Product product)
        {
            Product productToDelete;

            productToDelete = _products.SingleOrDefault(p=> p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
            
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate;
            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
