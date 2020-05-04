using System;

namespace DelEvent
{
    class Program
    {
        void changeSalary(int x, int y)
        {
            Console.WriteLine("Initial Salary: " + x + " Final Salary: " + y);
        }
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Ali", 10);
            Program p = new Program();
            // SalaryChangeDel sChange = p.changeSalary;
            // e1.SalaryChangeEve += new SalaryChangeDel(p.changeSalary);
            e1.SalaryChangeEve += p.changeSalary;
            e1.setSalary(15);
            Console.Read();
        }
    }
}
