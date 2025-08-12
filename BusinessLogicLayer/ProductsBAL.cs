namespace BusinessLogicLayer
{
    public class ProductsBAL
    {
        int _prodid;
        public int ProductID 
        {
            get { return _prodid; } 
            set 
            {
                if (value < 0)
                {
                    throw new Exception("Invalid Product ID");

                }
                else
                { 
                _prodid = value;    
                }
            
            } 
        }

        public string _prodname;
        public string ProductName { get { return _prodname; } set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid ProductName");
                }
                else
                {
                    _prodname = value;  
                }
            } 
        }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }

        public int ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

        public List<ProductsBAL> GetProducts()
        { }
        public bool AddProduct(ProductsBAL product)
        { }

        public bool DeleteProduct(int productid)
        { }

        public bool UpdateProduct(int id, ProductsBAL updatedProduct)
        { }

        public ProductsBAL FindProduct(int id) { }
        public ProductsBAL FindProduct(string prodname) { }



    }
}
