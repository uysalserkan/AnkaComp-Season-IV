using System;

namespace DelEvent
{
    public delegate void SalaryChangeDel(int x, int y);
    class Employee
    {
        public event SalaryChangeDel SalaryChangeEve;
        String name;
        int salary;
        public Employee(string n, int s)
        {
            this.name = n;
            this.salary = s;
        }
        public void setSalary(int s)
        {
            if (this.salary != s)
            {
                if(SalaryChangeEve!= null){
                    SalaryChangeEve(this.salary,s);
                }
            }
            this.salary = s;
        }
        public override string ToString(){
            return "Name :"+name+" Salary: "+salary;
        }
    }
}