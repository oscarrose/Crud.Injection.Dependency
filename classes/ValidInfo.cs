using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud.Injection.Interfacess;

namespace Crud.Injection.classes
{
    /// <summary>
    /// Clase para validar los datos
    /// </summary>
    public class ValidInfo : IValidInfo
    {
        

        public ValidInfo()
        {
            
        }


        /// <summary>
        /// Metodo para quitar el error mientras escribe
        /// </summary>
        /// <param name="control"></param>
        /// <param name="errorProvider"></param>
        /// <param name="s"></param>
        public void ClearError(Control control, ErrorProvider errorProvider, object s)
        {
            errorProvider.SetError((Control)s,"");
        }
        /// <summary>
        /// Metodo para validar si hay datos vacios
        /// </summary>
        /// <param name="control"></param>
        /// <param name="errorProvider"></param>
        /// <param name="message"></param>
        public void ValidInformation(Control control, ErrorProvider errorProvider, String message)
        {
          

            if (string.IsNullOrEmpty(control.Text))
            {
                errorProvider.SetError(control, message);
                Program.isvalid = false;
                
            }
        }


    }
}
