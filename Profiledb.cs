using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
namespace FriendApp.Models
{
    public class Profiledb
    {
        SqlConnection con = new SqlConnection("Data Source=SHRADDHAPC/SHRADDHASQL;Initial Catalog=Friends;Integrated Security=True");
        public void Profile(Profile pf)
        {
            con.Open();
            string sqlq = "Select Name from Friends where Phone='" + ISession["phn"] + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlq,con);
            DataSet ds = new DataSet();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
         
            }
        }
    }
}
