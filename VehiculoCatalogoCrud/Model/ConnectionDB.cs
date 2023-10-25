using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace VehiculoCatalogoCrud.Model
{
    internal class ConnectionDB
    {
        private SqlConnection _connection;
        private string _exceptionMessage;

        public ConnectionDB()
        {
        
        }

        public void openConnection() 
        {
            try
            {
                string stringConnection = ConfigurationManager.ConnectionStrings["StrConnection"].ToString();

                _connection = new SqlConnection(stringConnection);
                _connection.Open();
            }
            catch (Exception ex)
            {
                this._exceptionMessage = ex.Message;
            }
        }
    }
}
