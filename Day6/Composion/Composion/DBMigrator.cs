using System;

namespace Composion
{
    public class DBMigrator { 
        private readonly Logger _logger;
        public DBMigrator(Logger logger) { 
            _logger = logger;
        }
        
        public void migrate()
        {
            Console.WriteLine("we are migrating");
        }
    }
}
