using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Final_Project
{
    class ConnectionString
    {
        public SqlConnection cn = new SqlConnection("Data Source=LAPTOP-TI33LSUN;Initial Catalog=furniture;Integrated Security=True");
        public void ec()
        {
            try
            {
                cn.Close();
                cn.Open();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
