using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Operations;

namespace AccessForm
{
    public partial class Form1 : Form
    {
        Employee_Operations op = new Employee_Operations();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Fname = textBox1.Text;
            emp.Lname = textBox2.Text;
            op.Insert(emp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComboEmployee.DataSource = op.Fill_ComboBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee newEmp = new Employee();
            Employee oldEmp = new Employee();
            oldEmp = ComboEmployee.SelectedItem as Employee;

            newEmp.Fname = textBox3.Text;
            newEmp.Lname = textBox4.Text;

            op.Update(newEmp, oldEmp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp = ComboEmployee.SelectedItem as Employee;
            op.Delete(emp);
        }
    }
}
