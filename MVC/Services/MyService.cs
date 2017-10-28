using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Extensions.Configuration;


namespace MVC.Services
{
    public class MyService 
    {

        SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=master;Trusted_connection=True;MultipleActiveResultSets=ture;");


        public Object first(int i)
        {
            
            SqlCommand command = new SqlCommand("Select * from able", conn);
            conn.Open();
            
            var myData = new List<string>();
            SqlDataReader dr =command.ExecuteReader();
            while (dr.Read())
            {
                myData.Add(dr["name"].ToString());

            }
            return myData;
        }

        
    }
}
