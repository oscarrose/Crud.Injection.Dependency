using Crud.Injection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud.Injection.Interfacess;
using Crud.Injection.classes;
using Microsoft.Extensions.DependencyInjection;

namespace Crud.With.Inyector
{
    public partial class FrmHome : Form
    {
        private readonly IDataProduct dataProduct;
        private readonly ICrud crud;

        public FrmHome(IDataProduct dataProduct, ICrud crud)
        {
            InitializeComponent();

            this.dataProduct = dataProduct;
            this.crud = crud;

            BtnClose.Click += BtnClose_Click;
            btnNew.Click += BtnNew_Click;

            this.Load += FrmHome_Load;
            this.EditProduct.Click += EditProduct_Click;
            this.BtnDeleteProduct.Click += BtnDeleteProduct_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            Program.id = getid();
            crud.DeleteProduct();
            
            dataProduct.LoadDataProduct(DataGridProduct);
            Program.id = null;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

            if (true)
            {
                var frmproduct = Program.servicesProvider.GetService<FrmProduct>();
                frmproduct.ShowDialog();


            }
            dataProduct.LoadDataProduct(DataGridProduct);
           

        }

        private void EditProduct_Click(object sender, EventArgs e)
        {
            var frmproduct = Program.servicesProvider.GetService<FrmProduct>();
            Program.id= getid();
            if (Program.id != null)
            {
               
                
                frmproduct.ShowDialog();

            }
            dataProduct.LoadDataProduct(DataGridProduct);
            Program.id = null;
            frmproduct.ClearInput();

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            dataProduct.LoadDataProduct(dataGridProduct: DataGridProduct);
        }

        /// <summary>
        /// Obtener el id del items a editar
        /// </summary>
        /// <returns></returns>
        public  int? getid()
        {
            try
            {
                
                return int.Parse(DataGridProduct.Rows[DataGridProduct.CurrentRow.Index].Cells[0].Value.ToString());

            }
            catch
            {
                return null;

            }
        }

       
    }

   
    
}
