using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



namespace Database_1
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection(@"path");
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }
        public void DisplayData()
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new OleDbDataAdapter("select * from TableName", connection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
        public void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            ID = 0;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                connection.Open();
                cmd = new OleDbCommand("insert into person(fname,lname) values(@fname,@lname)", connection);
                cmd.Parameters.AddWithValue("@fname",textBox1.Text);
                cmd.Parameters.AddWithValue("@lname",textBox2.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                ClearData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                cmd = new OleDbCommand("update person set fname='" + textBox1.Text + "', lname='" + textBox2.Text + "' where ID='"+ID +"';", connection);
                cmd.ExecuteNonQuery();

                DisplayData();
                ClearData();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                cmd = new OleDbCommand("delete from person where ID='"+ID+"';", connection);
                cmd.ExecuteNonQuery();

                DisplayData();
                ClearData();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
