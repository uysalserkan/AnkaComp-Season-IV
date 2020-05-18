using System;
using System.Data;
using Data;
using System.Data.OleDb;
using System.Collections.Generic;

namespace Operations
{
    public class Employee_Operations
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        public void ConnectTo()
        {
            conn = new OleDbConnection("database.path");
            cmd = conn.CreateCommand();
        }
        public Employee_Operations()
        {
            ConnectTo();
        }
        public void Insert(Employee Emp)
        {
            try { 
                cmd.CommandText="INSERT INTO EMPLOYEE (FNAME,LNAME) VALUES('" + Emp.Fname + "','"+Emp.Lname+"');";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
            }catch(Exception e)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public List<Employee> Fill_ComboBox()
        {
            List<Employee> listOfEmployee = new List<Employee>();
            try
            {
                cmd.CommandText = "SELECT * FROM EMPOYEE;";
                cmd.CommandType = CommandType.Text;
                conn.Open();

                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employee emp = new Employee();
                    emp.Id = Convert.ToInt32(reader["ID"].toString());
                    emp.Fname = reader["FNAME"].toString();
                    emp.Lname = reader["LNAME"].toString();
                    listOfEmployee.Add(emp);
                }
                return listOfEmployee;
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void Update(Employee newEmp, Employee oldEmp)
        {
            try
            {
                cmd.CommandText = "UPDATE EMPLOYEE SET FNAME='"+newEmp.Fname+"' LNAME='"+newEmp.Lname+"' WHERE ID="+oldEmp.Id+";";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void Delete(Employee emp)
        {
            try
            {
                cmd.CommandText = "DELETE FROM EMPLOYEE WHERE ID ='"+emp.Id+"';";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
