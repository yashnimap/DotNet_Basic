using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composion
{
    internal class Program
     {
        static void Main(string[] args)
        {
            var dbmigrator = new DBMigrator(new Logger());
            var installer = new Installer(new Logger());

            dbmigrator.migrate();
            installer.Install();
        }
    }
}
