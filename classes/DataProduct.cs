using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud.Injection.Interfacess;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Stripe;
using System.Data.Entity;

namespace Crud.Injection.classes
{
    /// <summary>
    /// Clase para cargar los datos de products
    /// </summary>
    public class DataProduct : IDataProduct
    {
      

        /// <summary>
        /// De esta manaera la hizo yo 
        /// </summary>
        /// <param name="comboBox"></param>
        public void LlenarCategories(ComboBox comboBox)
        {
            
          using (NorthwindEntities db = new NorthwindEntities())
          {
                var consultCategoriesID = (from Category in db.Categories
                                           select new { Category.CategoryName, Category.CategoryID }).ToList();

                    comboBox.DataSource = consultCategoriesID;
                    comboBox.DisplayMember = ("CategoryName");
                    comboBox.ValueMember = ("CategoryID");
                   

               

          }
            
        }
        /// <summary>
        /// De esta manera lo implemente yo, menos codigo posible
        /// </summary>
        /// <param name="comboBox"></param>
        public void LlenarSuppliers(ComboBox comboBox)
        {
            using (NorthwindEntities db=new NorthwindEntities())
            {
               var ConsultSuppliers = (from suppliers in db.Suppliers
                                             select suppliers).ToList();

             
                    comboBox.DataSource = ConsultSuppliers;
                    comboBox.DisplayMember = ("CompanyName");
                    comboBox.ValueMember = ("SupplierID");


            }





        }
    

        public void LoadDataProduct(DataGridView dataGridProduct)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                //consulta para mostrar data
                var AllProduct = from products in db.Products
                                     //select products;
                                 select new
                                 {
                                     products.ProductID,
                                     products.ProductName,
                                     products.SupplierID,
                                     products.CategoryID,
                                     products.QuantityPerUnit,
                                     products.UnitPrice,
                                     products.UnitsOnOrder,
                                     products.UnitsInStock,
                                     products.ReorderLevel,
                                     products.Discontinued

                                 };

                // mostrando la data
                dataGridProduct.DataSource = AllProduct.ToList();



            }
        }
    }
}
