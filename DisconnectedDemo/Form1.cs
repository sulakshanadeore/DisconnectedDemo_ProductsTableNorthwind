using BusinessLogicLayer;

namespace DisconnectedDemo
{
    public partial class Form1 : Form
    {
        ProductsBAL bal = new ProductsBAL();

        public Form1()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ProductsBAL> list = bal.GetProducts();
            dataGridView1.DataSource = list;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnfindbyid_Click(object sender, EventArgs e)
        {
            ProductsBAL p = bal.FindProduct(Convert.ToInt32(txtprodid.Text));
            txtprodname.Text = p.ProductName;
            txtcatid.Text = p.CategoryID.ToString();
            txtsuppid.Text = p.SupplierID.ToString();
            txtprice.Text = p.UnitPrice.ToString();
            txtQtyPerUnit.Text = p.QuantityPerUnit.ToString();
            txtunitsinStock.Text = p.UnitsInStock.ToString();
            txtreorderlevel.Text = p.ReorderLevel.ToString();
            txtUnitsOnorder.Text = p.UnitsOnOrder.ToString();
            bool statusValue = p.Discontinued;
            if (statusValue)
            {
                comboBox1.Text = statusValue.ToString();

            }
            else
            {
                comboBox1.Text = statusValue.ToString();
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ProductsBAL p = new ProductsBAL();
            //  p.ProductID = Convert.ToInt32(txtprodid.Text);  
            p.CategoryID = Convert.ToInt32(txtcatid.Text);
            p.ProductName = txtprodname.Text.Trim();
            p.UnitPrice = Convert.ToDecimal(txtprice.Text);
            p.SupplierID = Convert.ToInt32(txtsuppid.Text);
            p.QuantityPerUnit = txtQtyPerUnit.Text.Trim().ToString();
            p.UnitsInStock = Convert.ToInt32(txtunitsinStock.Text);
            p.ReorderLevel = Convert.ToInt32(txtreorderlevel.Text);
            p.UnitsOnOrder = Convert.ToInt32(txtUnitsOnorder.Text);
            bool insertedStatus = bal.AddProduct(p);
            if (insertedStatus)
            {
                MessageBox.Show("Added Product Successfully...");
                Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Error Adding Product...");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductsBAL p = new ProductsBAL();
            //  p.ProductID = Convert.ToInt32(txtprodid.Text);  
            p.CategoryID = Convert.ToInt32(txtcatid.Text);
            p.ProductName = txtprodname.Text.Trim();
            p.UnitPrice = Convert.ToDecimal(txtprice.Text);
            p.SupplierID = Convert.ToInt32(txtsuppid.Text);
            p.QuantityPerUnit = txtQtyPerUnit.Text.Trim().ToString();
            p.UnitsInStock = Convert.ToInt32(txtunitsinStock.Text);
            p.ReorderLevel = Convert.ToInt32(txtreorderlevel.Text);
            p.UnitsOnOrder = Convert.ToInt32(txtUnitsOnorder.Text);
            bool updatedStatus = bal.UpdateProduct(Convert.ToInt32(txtprodid.Text), p);
            if (updatedStatus)
            {
                MessageBox.Show("Updated Product Successfully...");
                Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Error Updating Product...");
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool updatedStatus = bal.DeleteProduct(Convert.ToInt32(txtprodid.Text));
            if (updatedStatus)
            {
                MessageBox.Show("Deleted Product Successfully...");
                Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Error Deleting Product...");
            }
        }

        private void btnfindbyname_Click(object sender, EventArgs e)
        {
            ProductsBAL p = bal.FindProduct(txtprodname.Text.Trim());
            txtprodid.Text = p.ProductID.ToString();
            txtprodname.Text = p.ProductName;
            txtcatid.Text = p.CategoryID.ToString();
            txtsuppid.Text = p.SupplierID.ToString();
            txtprice.Text = p.UnitPrice.ToString();
            txtQtyPerUnit.Text = p.QuantityPerUnit.ToString();
            txtunitsinStock.Text = p.UnitsInStock.ToString();
            txtreorderlevel.Text = p.ReorderLevel.ToString();
            txtUnitsOnorder.Text = p.UnitsOnOrder.ToString();
            bool statusValue = p.Discontinued;
            if (statusValue)
            {
                comboBox1.Text = statusValue.ToString();

            }
            else
            {
                comboBox1.Text = statusValue.ToString();
            }
        }
    }
}
