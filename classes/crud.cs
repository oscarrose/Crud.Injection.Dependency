using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud.Injection.Interfacess;
using Crud.With.Inyector;
using Microsoft.Extensions.DependencyInjection;
using Crud.Injection.classes;
using System.Data.Entity;



namespace Crud.Injection.classes
{
    public class crud : ICrud
    {
        /// <summary>
        /// Para eliminar un product
        /// </summary>
        public void DeleteProduct()
        {
            

            if (Program.id != null)
            {
                try
                {
                    using (NorthwindEntities db = new NorthwindEntities())
                    {

                        try
                        {
                            var ConsultorderDateil = (from y in db.Order_Details
                                                      where y.ProductID == Program.id
                                                      select y).ToList();


                            var ConsultProduct = (from x in db.Products
                                                  where x.ProductID == Program.id
                                                  select x).Single();

                            var result = MessageBox.Show($"¿Desea eliminar? {ConsultProduct.ProductName}", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                            if (result == DialogResult.Yes)
                            {
                                foreach (var item in ConsultorderDateil)
                                {
                                    db.Order_Details.Remove(item);

                                }
                                db.Products.Remove(ConsultProduct);
                                db.SaveChanges();


                                
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("unexpected error" + ex, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("unexpected error the connection" + ex, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }




            }
        }
        /// <summary>
        /// Para editar los productos
        /// </summary>
        public void EditProduct()
        {
            try
            {
                using (NorthwindEntities db=new NorthwindEntities())
                {
                    var frmproduct = Program.servicesProvider.GetService<FrmProduct>();
                    Product produc = db.Products.Find(Program.id);

                    produc.ProductName = frmproduct.TxtProductName.Text;
                    produc.CategoryID = Convert.ToInt32(frmproduct.CbCategories.SelectedValue);
                    produc.SupplierID = Convert.ToInt32(frmproduct.CbSupplier.SelectedValue);
                    produc.QuantityPerUnit = frmproduct.TxtPerunit.Text;
                    produc.UnitPrice = Convert.ToDecimal(frmproduct.TxtPrice.Text);
                    produc.UnitsInStock = Convert.ToInt16(frmproduct.TxtStock.Text);
                    produc.UnitsOnOrder = Convert.ToInt16(frmproduct.txtOrder.Text);
                    produc.ReorderLevel = Convert.ToInt16(frmproduct.TxtLevel.Text);
                    produc.Discontinued = frmproduct.ChbDisc.Checked;

                    db.SaveChanges();

                    var result = MessageBox.Show($"Edit successfully! Products: {produc.ProductID}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        frmproduct.Close();
                        frmproduct.ClearInput();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        /// <summary>
        /// Para guardar los productos
        /// </summary>
        /// <param name="product"></param>
        public void GuardarProduct(Product product)
        {
            try
            {
                using (NorthwindEntities db = new NorthwindEntities())
                {



                    db.Products.Add(product);
                    db.SaveChanges();

                   var result= MessageBox.Show($"Saved successfully! Products: {product.ProductName}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result== DialogResult.OK)
                    {

                        var frmproduct = Program.servicesProvider.GetService<FrmProduct>();
                        
                        frmproduct.ClearInput();
                       
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unexpected error " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
