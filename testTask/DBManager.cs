using System;
using System.Configuration;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 

namespace testTask
{
    public class DBManager
    {

        private SqlConnection connect = null;

        public void OpenConnection(string connectionString)
        {
            connect = new SqlConnection(connectionString);

            try
            {
                connect.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void CloseConnection()
        {
            connect.Close();
        }

        public DataTable GetAllRecordsAsDataTable(string tableName)
        {
           
            DataTable employeesDT = new DataTable();
            string sqlExpression = string.Format("SELECT * FROM {0}", tableName);
            using (SqlCommand command = new SqlCommand(sqlExpression, this.connect))
            {
                SqlDataReader reader = command.ExecuteReader();
                try
                {                          
                    employeesDT.Load(reader);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    reader.Close();
                }
            }
            return employeesDT;
        }

        public List<string> GetPositions(string tableName)
        {
            List<string> positionsList = new List<string>();
            DataTable employeesDT = new DataTable();
            DataTableReader dtReader;
            string findExpression = "Position";
            string sqlExpression = string.Format("SELECT {1} FROM {0} GROUP BY {1}", tableName, findExpression);

            using (SqlCommand command = new SqlCommand(sqlExpression, this.connect))
            {
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    employeesDT.Load(reader);
                    dtReader = employeesDT.CreateDataReader();

                    while (dtReader.Read())
                        positionsList.Add(dtReader.GetValue(0).ToString());
                    dtReader.Close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    reader.Close();                 
                }                
            }
            return positionsList;
        }

        public int GetLastIndex(string tableName)
        {
            SqlDataReader reader;
            int index = -1;
            string sqlExpression = string.Format("SELECT MAX(ID) FROM {0}", tableName);

            using (SqlCommand command = new SqlCommand(sqlExpression, this.connect))
            {
                reader = command.ExecuteReader();
                reader.Read();
                index =  Convert.ToInt32(reader[0]); 
            }
            reader.Close();
            return index;
        }

        public SqlParameter CreateCommandParam(string paramName, string value, int size)

        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = string.Format("@{0}", paramName);
            param.Value = value;
            param.SqlDbType = SqlDbType.VarChar;
            param.Size = size;

            return param;
        }

        public SqlParameter CreateCommandParam(string paramName, int value)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = string.Format("@{0}", paramName);
            param.Value = value;
            param.SqlDbType = SqlDbType.Int;

            return param;
        }

        public SqlParameter CreateCommandParam(string paramName, double value)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = string.Format("@{0}", paramName);
            param.Value = value;
            param.SqlDbType = SqlDbType.Money;

            return param;
        }

        public void InsertRecord(string tableName, Employee newEmployee)
        {

            string sqlExpression = string.Format("Insert Into {0}" +
                "(Name, Surname, Position, BornYear, Salary) Values(N'{1}',N'{2}',N'{3}', {4}, {5})",
                tableName, newEmployee.name, newEmployee.surname, newEmployee.position, newEmployee.bornYear, newEmployee.salary);

            using (SqlCommand command = new SqlCommand(sqlExpression, this.connect))
            {

                command.Parameters.Add(CreateCommandParam("Name", newEmployee.name, 50));
                command.Parameters.Add(CreateCommandParam("Surname", newEmployee.surname, 50));
                command.Parameters.Add(CreateCommandParam("Position", newEmployee.position, 50));
                command.Parameters.Add(CreateCommandParam("BornYear", newEmployee.bornYear));
                command.Parameters.Add(CreateCommandParam("Salary", newEmployee.salary));

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void DeleteRecord(string tableName, int id)
        {
            string sqlExpression = string.Format("DELETE FROM {0} WHERE ID = '{1}'", tableName, id);
            using (SqlCommand command = new SqlCommand(sqlExpression, this.connect))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
