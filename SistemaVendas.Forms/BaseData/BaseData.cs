using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Forms.BaseData
{
    public class BaseData : IDisposable
    {
        protected OleDbConnection Connection = new OleDbConnection();
        protected OleDbCommand Command = new OleDbCommand();

        public BaseData()
        {
            try
            {
                Connection.ConnectionString = ConfigurationManager.ConnectionStrings["SistemaVendas.Forms.Properties.Settings.VendasConnectionString"].ToString();
                Connection.Open();
                Command.Connection = Connection;
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        public void Dispose()
        {
            if (Connection.State == ConnectionState.Open)
            {
                try { Command.Dispose(); }
                catch { }
                try { Connection.Dispose(); }
                catch { }
                try { Connection.Close(); }
                catch { }
            }
        }
    }
}
