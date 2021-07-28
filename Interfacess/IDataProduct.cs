using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud.Injection.classes;

namespace Crud.Injection.Interfacess
{
    public interface IDataProduct
    {
        void LoadDataProduct(DataGridView dataGridProduct);
        void LlenarSuppliers(ComboBox comboBox);

        void LlenarCategories(ComboBox comboBox);

        

    }
}
