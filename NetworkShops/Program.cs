using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkShops
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string sql = "Server=localhost;Port=5432;Database=courseproject; User id = postgres; Password = totalWar1234;";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new KadrovikForm());
            //Application.Run(new DirectorNetworkShops());
            //Application.Run(new DirectorShop());


            //Application.Run(new Assistant());
        }
    }
}
