namespace Indexer
{
    public class Employee {
        int eno;
        double salary;
        string Ename, job, dname, locaion;

        public Employee(int eno, double salary, string ename, string job, string dname, string location) { 
            this.eno = eno; 
            this.salary = salary;
            this.Ename = ename;
            this.job = job;
            this.dname = dname;
            this.locaion = location;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return eno;
                }
                else if (index == 1)
                {
                    return salary;
                }
                else if (index == 2)
                {
                    return Ename;
                }
                else if (index == 3)
                {
                    return job;
                }
                else if (index == 4)
                {
                    return dname;
                }
                else if(index == 5)
                {
                    return locaion;
                }
                return null;

            }
        }
    }
}
