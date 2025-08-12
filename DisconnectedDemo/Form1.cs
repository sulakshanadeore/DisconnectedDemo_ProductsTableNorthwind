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
            ProductsBAL p=bal.FindProduct(Convert.ToInt32(txtprodid.Text));
            txtprodname.Text = p.ProductName;
            txtcatid.Text = p.CategoryID.ToString();
            txtsuppid.Text = p.SupplierID.ToString();
            txtprice.Text = p.UnitPrice.ToString();
            txtQtyPerUnit.Text=p.QuantityPerUnit.ToString();
            txtunitsinStock.Text = p.UnitsInStock.ToString();
            txtreorderlevel.Text = p.ReorderLevel.ToString();
            txtUnitsOnorder.Text=p.UnitsOnOrder.ToString();
            bool statusValue=p.Discontinued;
            if (statusValue) {
                comboBox1.Text = statusValue.ToString();
            
            }
            else
            {
                comboBox1.Text = statusValue.ToString();
            }
            
        }
    }
}
