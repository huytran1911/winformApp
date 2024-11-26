using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;
using DTO;
namespace DAL
{
    public class FrmChonMonDAL
    {
        public DataTable GetMenu()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(DB.connectionString))
            {
                string query = "SELECT * FROM Menu";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
    }
}
