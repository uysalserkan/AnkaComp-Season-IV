using System;

namespace Data
{
    public class Employee
    {
        private int id;
        private string fname;
        private string lname;

        public string Fname { get => fname; set => fname = value; }
        public int Id { get => id; set => id = value; }
        public string Lname { get => lname; set => lname = value; }
        public override string ToString()
        {
            return Fname + " " + Lname;
        }
    }
}
