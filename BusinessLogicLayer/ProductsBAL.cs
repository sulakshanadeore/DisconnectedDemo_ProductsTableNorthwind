using DataAccessLayer;
using System.Net.Http.Headers;

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

        ProductsDALOperations operations = new ProductsDALOperations();
        public List<ProductsBAL> GetProducts()
        {

            List<ProductsBAL> productList=new List<ProductsBAL>();

            List<Products> plist=operations.ShowAll();
            foreach (var item in plist)
            {
                productList.Add(new ProductsBAL {ProductID=item.ProductID,
                    ProductName=item.ProductName,
                    SupplierID=item.SupplierID,
                CategoryID=item.CategoryID, 
                    UnitPrice=item.UnitPrice, 
                    QuantityPerUnit=item.QuantityPerUnit, 
                    UnitsInStock=item.UnitsInStock, 
                    UnitsOnOrder=item.UnitsOnOrder,
                    ReorderLevel=item.ReorderLevel,
                    Discontinued=item.Discontinued});
            }

            return productList; 

        }
        public bool AddProduct(ProductsBAL item)
        {
            Products p = new Products();
            p.ProductID =item.ProductID;
            p.ProductName = item.ProductName;
            p.SupplierID = item.SupplierID;
            p.CategoryID = item.CategoryID; 
                    p.UnitPrice = item.UnitPrice;
                    p.QuantityPerUnit = item.QuantityPerUnit,;
            p.UnitsInStock = item.UnitsInStock;
            p.UnitsOnOrder = item.UnitsOnOrder;
            p.ReorderLevel = item.ReorderLevel;
                    p.Discontinued = item.Discontinued;

           bool result= operations.InsertProduct(p);
            if (result)
            {
                return true;

            }
            return false;
        
        }

        public bool DeleteProduct(int productid)
        { 
     bool result   =operations.RemoveProduct(productid);
            if (result)
            {
                return true;

            }
            return false;

        }

        public bool UpdateProduct(int id, ProductsBAL updatedProduct)
        {
            Products p = new Products();
            p.ProductID = updatedProduct.ProductID;
            p.ProductName = updatedProduct.ProductName;
            p.SupplierID = updatedProduct.SupplierID;
                p.CategoryID = updatedProduct.CategoryID;
                    p.UnitPrice = updatedProduct.UnitPrice;
                    p.QuantityPerUnit = updatedProduct.QuantityPerUnit,;
                    p.UnitsInStock = updatedProduct.UnitsInStock; 
                    p.UnitsOnOrder = updatedProduct.UnitsOnOrder;
                    p.ReorderLevel = updatedProduct.ReorderLevel;
                    p.Discontinued = updatedProduct.Discontinued;


            bool result = operations.EditProduct(id,p);
            if (result)
            {
                return true;

            }
            return false;


        }

        public ProductsBAL FindProduct(int id) {
            Products found=operations.SearchProductByID(id);
            ProductsBAL p=new  ProductsBAL();
            p.ProductID = found.ProductID;
            p.ProductID = found.ProductID;
            p.ProductName = found.ProductName;
            p.SupplierID = found.SupplierID;
            p.CategoryID = found.CategoryID;
            p.UnitPrice = found.UnitPrice;
            p.QuantityPerUnit = found.QuantityPerUnit,;
            p.UnitsInStock = found.UnitsInStock;
            p.UnitsOnOrder = found.UnitsOnOrder;
            p.ReorderLevel = found.ReorderLevel;
            p.Discontinued = found.Discontinued;
            return p;
        }
        public ProductsBAL FindProduct(string prodname) 
        {
            Products found = operations.SearchProductByName(prodname);
            ProductsBAL p = new ProductsBAL();
            p.ProductID = found.ProductID;
            p.ProductID = found.ProductID;
            p.ProductName = found.ProductName;
            p.SupplierID = found.SupplierID;
            p.CategoryID = found.CategoryID;
            p.UnitPrice = found.UnitPrice;
            p.QuantityPerUnit = found.QuantityPerUnit,;
            p.UnitsInStock = found.UnitsInStock;
            p.UnitsOnOrder = found.UnitsOnOrder;
            p.ReorderLevel = found.ReorderLevel;
            p.Discontinued = found.Discontinued;
            return p;


        }



    }
}
