using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibraryDAL
{
    public class ProductDAL
    {
        public static int SaveProduct()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            string command = "insert into product(name)values('fanta')";
            SqlCommand cmd = new SqlCommand(command, con);
            int i= cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }

        public static void DeleteProduct()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            string command = "DELETE FROM product WHERE ID=(SELECT MAX(id) FROM product)";
            SqlCommand cmd = new SqlCommand(command, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

    }
}
