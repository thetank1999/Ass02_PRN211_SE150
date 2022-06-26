﻿using BussinessObject.Context;
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class ProductDAO
    {
        #region [ Using Singleton ]
        private static ProductDAO instance = null;
        public static readonly object instanceLock = new object();
        public static ProductDAO Instance {
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        #endregion

        #region [ Search Product By StringName ]
        public IEnumerable<Product> FilterProductList(string name) {
            var ProductList = new List<Product>();
            try {
                using var context = new FStoreDBContext();
                ProductList = context.Products.Where(x => x.ProductName.Contains(name)).ToList(); //, StringComparison.CurrentCultureIgnoreCase
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return ProductList;
        }
        #endregion

        #region [ CRUD ]
        public IEnumerable<Product> GetProductList() {
            var ProductList = new List<Product>();
            try {
                using var context = new FStoreDBContext();
                ProductList = context.Products.ToList();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return ProductList;
        }

        public Product GetProductById(int id) {
            Product _tempProduct = null;
            try {
                using var context = new FStoreDBContext();
                _tempProduct = context.Products.FirstOrDefault(x => x.ProductId == id);
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return _tempProduct;
        }

        public void AddProduct(Product _Product) {
            try {
                var _tempProduct = this.GetProductById(_Product.ProductId);
                if (_tempProduct == null) {
                    using var context = new FStoreDBContext();
                    //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[User] ON");
                    //context.Database.OpenConnection();
                    context.Products.Add(_Product);
                    context.SaveChanges();
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void UpdateProduct(Product _Product) {
            try {
                Product tempProduct = this.GetProductById(_Product.ProductId);
                if (tempProduct != null) {
                    using var context = new FStoreDBContext();
                    context.Products.Update(_Product);
                    context.SaveChanges();

                } else {
                    throw new Exception("The Product Id is not existed.");

                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void RemoveProduct(Product _Product) {
            try {
                Product _tempProduct = this.GetProductById(_Product.ProductId);
                if (_tempProduct != null) {
                    using var context = new FStoreDBContext();
                    context.Products.Remove(_tempProduct);
                    context.SaveChanges();
                } else {
                    throw new Exception("The Product Id is not existed.");
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }
        #endregion
    }
}
