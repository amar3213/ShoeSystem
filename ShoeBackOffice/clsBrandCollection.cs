using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeBackOffice
{
    class clsBrandCollection
    {
        SqlConnection con = new SqlConnection(@"Data Source=v00egd00001l.lec-admin.dmu.ac.uk;Initial Catalog=p2521296;User ID=p2521296;Password=isright12;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public string name { get; set; }
        public int id { get; set; }
        public int setBrand(clsBrand brand)
        {
            SqlCommand cmd = new SqlCommand("sproc_tblBrand_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", brand.Name);

            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();
            return i;
        }
        public int editBrand(clsBrand brand)
        {
            SqlCommand cmd = new SqlCommand("sproc_tblBrand_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", brand.Name);
            cmd.Parameters.AddWithValue("@id", brand.ID);
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();
            return i;
        }
        public int deleteBrand(clsBrand brand)
        {
            SqlCommand cmd = new SqlCommand("sproc_tblBrand_Delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", brand.ID);
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();
            return i;
        }
    }
}
