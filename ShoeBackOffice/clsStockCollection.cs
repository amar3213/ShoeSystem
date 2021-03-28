using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeBackOffice
{
    class clsStockCollection
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=v00egd00001l.lec-admin.dmu.ac.uk;Initial Catalog=p2521296;User ID=p2521296;Password=isright12;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public int ID;
        public int Brand;
        public string name;
        public int size;
        public DateTime date;
        public int quantity;
        public int cost;

        public int setStock(clsStock Stock)
        {
            Brand = Stock.brand;
            name = Stock.name;
            size = Stock.size;
            date = Stock.date;
            quantity = Stock.quantity;
            cost = Stock.cost;
            SqlCommand cmd = new SqlCommand("sproc_tblStock_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@size", size);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.Parameters.AddWithValue("@brand", Brand);

            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();
            return i;
        }
        public int deleteStock(clsStock stock)
        {
            SqlCommand cmd = new SqlCommand("sproc_tblStock_Delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", stock.ID);
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();
            return i;
        }
        public int UpdateStock(clsStock Stock)
        {
            Brand = Stock.brand;
            name = Stock.name;
            size = Stock.size;
            date = Stock.date;
            quantity = Stock.quantity;
            cost = Stock.cost;
            ID = Stock.ID;
            SqlCommand cmd = new SqlCommand("sproc_tblStock_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@size", size);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.Parameters.AddWithValue("@brand", Brand);
            cmd.Parameters.AddWithValue("@id", ID);
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();
            return i;
        }

        public DataSet Search(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter("select [tblStock].ID as ID,[tblBrand].Name as Brand,[tblStock].Name as Name,[tblStock].Size as size,[tblStock].Quantity as Quantity,[tblStock].Cost as cost,[tblStock].ReleaseDate as date from [tblStock] inner join tblBrand on tblBrand.ID = tblStock.brand where tblStock.Name LIKE '%" + name + "%'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblStock");
            con.Open();

            con.Close();
            return ds;
        }
    }
}
