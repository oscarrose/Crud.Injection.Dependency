using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud.Injection;
using Crud.Injection.Interfacess;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System.Data.Entity.SqlServer;
using System.Data.Entity;
using System.Data.Sql;
using Unipluss.Sign.ExternalContract.Entities;

namespace Crud.With.Inyector
{
    public partial class FrmProduct : Form
    {
       
        private readonly IValidInfo validInfo;
        private readonly IDataProduct dataProduct;
        private readonly ICrud Crud;


        public FrmProduct(IValidInfo validInfo, IDataProduct dataProduct, ICrud Crud)
        {
            InitializeComponent();
            btnGuardar.Click += BtnGuardar_Click;

            this.validInfo = validInfo;
            this.dataProduct = dataProduct;
            this.Crud = Crud;
            
      

            this.Load += FrmProduct_Load;
         
            TxtProductName.TextChanged += TxtProductName_TextChanged;
            CbSupplier.TextChanged += CbSupplier_TextChanged;
            CbCategories.TextChanged += CbCategories_TextChanged;
            TxtPerunit.TextChanged += TxtPerunit_TextChanged;
            TxtPrice.TextChanged += TxtPrice_TextChanged;
            TxtPrice.TextChanged += TxtPrice_TextChanged1;
            TxtStock.TextChanged += TxtStock_TextChanged;
            txtOrder.TextChanged += TxtOrder_TextChanged;
            TxtLevel.TextChanged += TxtLevel_TextChanged;

           
        }

     

        private void TxtLevel_TextChanged(object sender, EventArgs e)
        {
            validInfo.ClearError(TxtLevel, errorProviderProduct, sender);
        }

        private void TxtOrder_TextChanged(object sender, EventArgs e)
        {
            validInfo.ClearError(txtOrder, errorProviderProduct, sender);
        }

        private void TxtStock_TextChanged(object sender, EventArgs e)
        {
            validInfo.ClearError(TxtStock, errorProviderProduct, sender);
        }

        private void TxtPrice_TextChanged1(object sender, EventArgs e)
        {
            validInfo.ClearError(TxtPrice, errorProviderProduct, sender);
        }

        private void TxtPrice_TextChanged(object sender, EventArgs e)
        {
            validInfo.ClearError(TxtPrice, errorProviderProduct, sender);
        }

        private void TxtPerunit_TextChanged(object sender, EventArgs e)
        {
            validInfo.ClearError(TxtPerunit, errorProviderProduct, sender);
        }

        private void CbCategories_TextChanged(object sender, EventArgs e)
        {
            validInfo.ClearError(CbCategories, errorProviderProduct, sender);
        }

        private void CbSupplier_TextChanged(object sender, EventArgs e)
        {
            validInfo.ClearError(CbSupplier, errorProviderProduct, sender);
        }

        private void TxtProductName_TextChanged(object sender, EventArgs e)
        {
            validInfo.ClearError(TxtProductName, errorProviderProduct, sender);
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            dataProduct.LlenarCategories(CbCategories);

            dataProduct.LlenarSuppliers(CbSupplier);
            if (Program.id != null)
            {
                LoadProductEdit();
                LbTitle.Text = "Edit Product";

            }
            else
            {
                LbTitle.Text = "Add Product";
            }

          
        }

        public void BtnGuardar_Click(object sender, EventArgs e)
         {
           
            try
            {
                
                validInfo.ValidInformation(TxtProductName, errorProviderProduct, "The produce name is requerid");
                validInfo.ValidInformation(TxtPerunit, errorProviderProduct, "The quantity perunit is requerid");
                validInfo.ValidInformation(TxtPrice, errorProviderProduct, "The unit price is requerid");
                validInfo.ValidInformation(TxtStock, errorProviderProduct, "The unit stock is requerid");
                validInfo.ValidInformation(txtOrder, errorProviderProduct, "The units order is requerid");
                validInfo.ValidInformation(TxtLevel, errorProviderProduct, "The recorder level is requerid");
                validInfo.ValidInformation(CbSupplier, errorProviderProduct, "The suppliers is requerid");
                validInfo.ValidInformation(CbCategories, errorProviderProduct, "The categories is requerid");
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            //Para guardar un nuevo product
            if (Program.id==null)
            {
                if (Program.isvalid)
                {
                   
                    Product product = new Product();

                    product.ProductName = TxtProductName.Text;
                    product.CategoryID = Convert.ToInt32(CbCategories.SelectedValue);
                    product.SupplierID = Convert.ToInt32(CbSupplier.SelectedValue);
                    product.QuantityPerUnit = TxtPerunit.Text;
                    product.UnitPrice = Convert.ToDecimal(TxtPrice.Text);
                    product.UnitsInStock = Convert.ToInt16(TxtStock.Text);
                    product.UnitsOnOrder = Convert.ToInt16(txtOrder.Text);
                    product.ReorderLevel = Convert.ToInt16(TxtLevel.Text);
                    product.Discontinued = ChbDisc.Checked;

                    Crud.GuardarProduct(product);


                }
            }
            //Para editar un product
            if (Program.id!=null)
            {
                Crud.EditProduct();
               

            }


        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }

        /// <summary>
        /// Para limpiar los input
        /// </summary>
        public void ClearInput()
        {
            TxtProductName.Clear();
            TxtPerunit.Clear();
            TxtPrice.Clear();
            TxtStock.Clear();
            txtOrder.Clear();
            TxtLevel.Clear();

        }

        /// <summary>
        /// Para buscar los id y cargar los datos en el datagrid para editar
        /// </sum   x`mary>
        private void LoadProductEdit() {
            using (NorthwindEntities db=new NorthwindEntities()) {

                try
                {
                    Product product = new Product();
                    product = db.Products.Find(Program.id);
                    
                    TxtProductName.Text = product.ProductName.ToString();

                    CbSupplier.SelectedValue = product.SupplierID;
                    CbCategories.SelectedValue = product.CategoryID;

                    TxtPerunit.Text = product.QuantityPerUnit;
                    TxtPrice.Text = product.UnitPrice.ToString();
                    TxtStock.Text = product.UnitsInStock.ToString();
                    txtOrder.Text = product.UnitsOnOrder.ToString();
                    TxtLevel.Text = product.ReorderLevel.ToString();
                    ChbDisc.Checked = product.Discontinued;
             
                }
                catch (Exception ex)
                {

                  MessageBox.Show($"unexpected error {ex}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
                
            
            
            }

        }


    }

  
   


}


