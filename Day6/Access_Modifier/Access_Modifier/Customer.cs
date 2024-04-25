using System;

namespace Access_Modifier
{
    public class Customer { 
        public int Id { get; set; } 
        public string Name { get; set; }

        public void Promote() {
            var rating = Calculating(excludeorder: true);
            if (rating == 0)
            {
                Console.WriteLine("Promote to level 1");
            }
            else
            {
                Console.WriteLine("Promote to level 2");
            }
        }

        private int Calculating(bool excludeorder)
        {
            return 0;
        }
    }
}
