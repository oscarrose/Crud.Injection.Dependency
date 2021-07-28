using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud.Injection.classes;

namespace Crud.Injection.Interfacess
{
  public  interface IValidInfo
    {
        void ValidInformation(Control control, ErrorProvider errorProvider, String message);
        void ClearError(Control control, ErrorProvider errorProvider, object s);
       
     
  }
}
