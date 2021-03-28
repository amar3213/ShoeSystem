using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeBackOffice
{
    public partial class StockManagement : MetroFramework.Forms.MetroForm
    {
        clsBrand brand = new clsBrand();
        int id;
          
        SqlConnection con = new SqlConnection(@"Data Source=v00egd00001l.lec-admin.dmu.ac.uk;Initial Catalog=p2521296;User ID=p2521296;Password=isright12;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public StockManagement()
        {
            InitializeComponent();
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            btnUpdateBrand.Hide();
            btnDeleteBrand.Hide();
            btnUpdateStock.Hide();
            btnDeleteStock.Hide();
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            GetBrands();
            
            BrandsName();
            GetStock();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            Login form = new Login();
            form.Show();
            this.Hide();
            
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            clsBrand brand1 = new clsBrand();
            brand1.Name = txtBrandName.Text;
            clsBrandCollection brand = new clsBrandCollection();
            int i = brand.setBrand(brand1);

            if (i != 0)
            {
                MessageBox.Show("Data Saved");
                txtBrandName.Clear();
                GetBrands();
                BrandsName();

            }
            else
            {
                MessageBox.Show("Failed to Inert Data.");
            }
        }

        private void btnCancelBrand_Click(object sender, EventArgs e)
        {
           btnAddBrand.Show();
            btnDeleteBrand.Hide();
            btnUpdateBrand.Hide();
            txtBrandName.Clear();
        }

        private void btnUpdateBrand_Click(object sender, EventArgs e)
        {
            clsBrand brand1 = new clsBrand();
            brand1.Name = txtBrandName.Text;
            brand1.ID = id;
            clsBrandCollection brand = new clsBrandCollection();
            int i = brand.editBrand(brand1);

            if (i != 0)
            {
                MessageBox.Show("Data Updated.");
                txtBrandName.Clear();
                GetBrands();
                BrandsName();
                btnUpdateBrand.Hide();
                btnDeleteBrand.Hide();
                btnAddBrand.Show();
                txtBrandName.Clear();

            }
            else
            {
                MessageBox.Show("Failed to Update Data.");
            }
        }

        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            clsBrand brand1 = new clsBrand();
            brand1.Name = txtBrandName.Text;
            brand1.ID = id;
            clsBrandCollection brand = new clsBrandCollection();
            int i = brand.deleteBrand(brand1);

            if (i != 0)
            {
                MessageBox.Show("Data Deleted.");
                txtBrandName.Clear();
                GetBrands();
                BrandsName();
                btnAddBrand.Show();
                btnDeleteBrand.Hide();
                btnUpdateBrand.Hide();
                txtBrandName.Clear();

            }
            else
            {
                MessageBox.Show("Failed to Delete Data.");
            }
        }

        public void GetBrands()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblBrand", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblBrand");
            con.Open();

            dataGridView1.DataSource = ds.Tables["tblBrand"].DefaultView;

            con.Close();
        }

        public void BrandsName()
        {
            string query = "select ID,Name from tblBrand";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "tblBrand");
            cmbBrand.DisplayMember = "Name";
            cmbBrand.ValueMember = "ID";
            cmbBrand.DataSource = ds.Tables["tblBrand"];
            con.Close();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            clsStock stock = new clsStock();
            stock.name = txtProductName.Text;
            stock.brand = Convert.ToInt32(cmbBrand.SelectedValue);

            stock.size = Convert.ToInt32(cmbSize.Text);
            stock.quantity = Convert.ToInt32(txtQuantity.Text);
            stock.date = dtpReleaseDate.Value;
            stock.cost = Convert.ToInt32(txtCost.Text);
            clsStockCollection stock2 = new clsStockCollection();
            int i = stock2.setStock(stock);

            if (i != 0)
            {
                MessageBox.Show("Data Saved");
                txtProductName.Clear();
                txtCost.Clear();
                txtQuantity.ResetText();

                GetStock();

            }
            else
            {
                MessageBox.Show("Failed to Inert Data.");
            }
        }

        private void btnCancelStock_Click(object sender, EventArgs e)
        {
            txtProductName.Clear();
            txtCost.Clear();
            cmbBrand.SelectedIndex = -1;
            cmbSize.SelectedIndex = -1;
            dtpReleaseDate.Text = "";
            txtQuantity.Value = 0; ;
            btnAddStock.Show();
            btnUpdateStock.Hide();
            btnDeleteStock.Hide();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            clsStock stock = new clsStock();
            stock.name = txtProductName.Text;
            stock.brand = Convert.ToInt32(cmbBrand.SelectedValue);

            stock.size = Convert.ToInt32(cmbSize.Text);
            stock.quantity = Convert.ToInt32(txtQuantity.Text);
            stock.date = dtpReleaseDate.Value;
            stock.cost = Convert.ToInt32(txtCost.Text);
            stock.ID = id;
            clsStockCollection Stock = new clsStockCollection();
            int i = Stock.UpdateStock(stock);

            if (i != 0)
            {
                MessageBox.Show("Data Updated.");
                txtProductName.Clear();
                txtCost.Clear();
                cmbBrand.SelectedIndex = -1;
                cmbSize.SelectedIndex = -1;
                dtpReleaseDate.Text = "";
                txtQuantity.Value = 0; ;
                btnAddStock.Show();
                btnDeleteStock.Hide();
                btnUpdateStock.Hide();
                GetStock();
            }
            else
            {
                MessageBox.Show("Failed to Update Data.");
            }
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            clsStock stock = new clsStock();

            stock.ID = id;
            clsStockCollection Stock = new clsStockCollection();
            int i = Stock.deleteStock(stock);

            if (i != 0)
            {
                MessageBox.Show("Data Deleted.");
                txtProductName.Clear();
                txtCost.Clear();
                cmbBrand.SelectedIndex = -1;
                cmbSize.SelectedIndex = -1;
                dtpReleaseDate.Text = "";
                txtQuantity.Value = 0; ;
                btnAddStock.Show();
                btnDeleteStock.Hide();
                btnUpdateStock.Hide();
                GetStock();
            }
            else
            {
                MessageBox.Show("Failed to Delete Data.");
            }
        }

        private void btnSearchStock_Click(object sender, EventArgs e)
        {
            clsStockCollection stock = new clsStockCollection();
            DataSet ds = stock.Search(txtProductSearch.Text);
            dataGridView2.DataSource = ds.Tables["tblStock"].DefaultView;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtProductSearch.Clear();
            GetStock();
        }

        public void GetStock()
        {
            SqlDataAdapter da = new SqlDataAdapter("select [tblStock].ID as ID,[tblBrand].Name as Brand,[tblStock].Name as Name,[tblStock].Size as size,[tblStock].Quantity as Quantity,[tblStock].Cost as cost,[tblStock].ReleaseDate as date from [tblStock] inner join tblBrand on tblBrand.ID = tblStock.brand", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblStock");
            con.Open();
            //dataGridView1.ColumnCount = 3;
            //dataGridView1.Columns[0].Name = "ID";
            //dataGridView1.Columns[1].Name = "Brand Name";
            //dataGridView1.Columns[2].Name = "Action";
            dataGridView2.DataSource = ds.Tables["tblStock"].DefaultView;
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue);
                brand.Name = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtBrandName.Text = brand.Name;
                btnAddBrand.Hide();
                btnUpdateBrand.Show();
                btnDeleteBrand.Show();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView2.CurrentRow.Selected = true;
                id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["ID"].FormattedValue);
                txtProductName.Text = dataGridView2.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                cmbBrand.Text = dataGridView2.Rows[e.RowIndex].Cells["Brand"].FormattedValue.ToString();
                cmbSize.Text = dataGridView2.Rows[e.RowIndex].Cells["size"].FormattedValue.ToString();
                dtpReleaseDate.Text = dataGridView2.Rows[e.RowIndex].Cells["date"].FormattedValue.ToString();
                txtQuantity.Value = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["Quantity"].FormattedValue);
                txtCost.Text = dataGridView2.Rows[e.RowIndex].Cells["cost"].FormattedValue.ToString();
                btnAddStock.Hide();
                btnUpdateStock.Show();
                btnDeleteStock.Show();
            }
        }
    }
}
