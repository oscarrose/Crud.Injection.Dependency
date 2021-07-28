using Crud.With.Inyector;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud.Injection.Interfacess;
using Crud.Injection.classes;



namespace Crud.Injection
{
    
    static class Program
    {
        public static IServiceProvider servicesProvider;
        public static bool isvalid=true;
        public static int? id;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          

            var services = new ServiceCollection();
            settingServices(services);

            servicesProvider = services.BuildServiceProvider();
            
                var frmhome = servicesProvider.GetRequiredService<FrmHome>();
                //var frmProduct = servicesProvider.GetRequiredService<FrmProduct>();
                
                Application.Run(frmhome);
            
        }
        /// <summary>
        /// Metodo para agragar las dependencias 
        /// </summary>
        /// <param name="services"></param>
        private static void settingServices(ServiceCollection services)
        {
            services.AddScoped<IDataProduct, DataProduct>();
            services.AddScoped<IValidInfo,ValidInfo>();
            services.AddScoped<ICrud, crud>();
            services.AddScoped<FrmHome>();
            services.AddScoped<FrmProduct>();

        }

       

    }
}
