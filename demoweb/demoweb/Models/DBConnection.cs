using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Drawing;

namespace demoweb.Models
{

    //chi su dung de connection den database
    public class DBConnection
    {
        
        string strConnect;

        public DBConnection()

        {
            /*var connectionString = "Server=127.0.0.1; Initial Catalog=ADONETEXAMPLE; User ID=testado; Password=testado.net; Application Name=Test ADP.NET";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }*/
        }
        public SqlConnection getConnection()//lay ket noi
        {
            /* var connectionString = "Server=localhost; Initial Catalog=Student; User ID=sa; Password=123456aA@$";
             SqlConnection conn = new SqlConnection(
             new SqlConnectionStringBuilder()
             {
                 DataSource = "ServerName",
                 InitialCatalog = "DatabaseName",
                 UserID = "UserName",
                 Password = "UserPassword"
             }.ConnectionString);*/
            

            return new SqlConnection(
            
            "Data Source=localhost;" +
            "Initial Catalog=Student;" +
            "User id=sa;" +
            "Password=123456aA@$");
        }
    }
}

