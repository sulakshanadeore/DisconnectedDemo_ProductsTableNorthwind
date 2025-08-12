using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductsDALOperations
    {
        SqlConnection cn = null;
        SqlDataAdapter da_products = null;
        DataSet dsNw=new DataSet();
        DataTable dt = null;
        public ProductsDALOperations()
        {
            string connectionstring = "server=mazenet-test;" +
            "Integrated Security=true;" +
            "database=northwind;TrustServerCertificate=true";
            cn =new SqlConnection(connectionstring);
            da_products = new SqlDataAdapter("Select * from products", cn); 
            da_products.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //1 Connection can be used for all operations and 1 dataadapter for 1 table
            //name of the dataset to fill into, and the name to be given to the DataTAble
            da_products.Fill(dsNw, "Products");//disconnected from the database server
            //In-memory copy--->Products
            dt = dsNw.Tables["Products"];

        }


        public List<Products> ShowAll()
        {
            //dsNw.Tables[0];
            int rowsCount=dt.Rows.Count;
            List<Products> productslist=new List<Products>();
            for (int i = 0; i < rowsCount; i++)
            {
                Products product = new Products();
                product.ProductID = Convert.ToInt32(dt.Rows[i]["ProductID"]);
                product.ProductName = dt.Rows[i]["ProductName"].ToString();
                product.SupplierID= Convert.ToInt32(dt.Rows[i]["SupplierID"]);
                product.CategoryID= Convert.ToInt32(dt.Rows[i]["CategoryID"]);
                product.QuantityPerUnit = dt.Rows[i]["QuantityPerUnit"].ToString();
                product.UnitPrice = Convert.ToDecimal(dt.Rows[i]["UnitPrice"]);
                product.UnitsInStock= Convert.ToInt16(dt.Rows[i]["UnitsInStock"]);
                product.UnitsOnOrder = Convert.ToInt16(dt.Rows[i]["UnitsOnOrder"]);
                product.ReorderLevel = Convert.ToInt16(dt.Rows[i]["ReorderLevel"]);
              //  int val =Convert.ToInt32(dt.Rows[i]["Discontinued"]);
                bool isActive= (Convert.ToInt32(dt.Rows[i]["Discontinued"])==0) ? true: false;
               product.Discontinued= isActive;

                productslist.Add(product);

          
            }

      return productslist;
        }
        public bool InsertProduct(Products product)
        {
            DataRow newrow=dt.NewRow();//blank row
            newrow["ProductName"]=product.ProductName;
            newrow["SupplierID"]=product.SupplierID;
            newrow["CategoryID"] = product.CategoryID;
            newrow["QuantityPerUnit"] = product.QuantityPerUnit;
            newrow["UnitPrice"] = product.UnitPrice;
            newrow["UnitsInStock"]=product.UnitsInStock;
            newrow["UnitsOnOrder"] = product.UnitsOnOrder;
            newrow["ReorderLevel"] = product.ReorderLevel;
            newrow["Discontinued"]=product.Discontinued;    //Populate data in blank row
            dt.Rows.Add(newrow);
            SqlCommandBuilder bldr = new SqlCommandBuilder(da_products);
          int rowsAffected=  da_products.Update(dsNw, "Products");

            bool status = false;
            if (rowsAffected>0)
            {
                status = true;
            }
            return status;

            }
      


        
        

        public bool RemoveProduct(int productid)
        { 
        //Check whether primary key info is updated to the DataSet of the App
        //da.MissingSchemaAction=MissingSchemaAction.AddWithKey;
        DataRow rowfound=dt.Rows.Find(productid);
            if (rowfound != null)
            {
              dt.Rows.Remove(rowfound);//Deleted from DataTable

                //to delete from db
                SqlCommandBuilder bldr = new SqlCommandBuilder(da_products);
                int rowsAffected = da_products.Update(dsNw, "Products");

                bool status = false;
                if (rowsAffected > 0)
                {
                    status = true;
                }
                return status;


            }
            else
            {
                throw new Exception("Product ID doesn't exists");
            }
        
        }

        public bool EditProduct(int id, Products updatedProduct)
        {
            DataRow rowfound = dt.Rows.Find(id);
            if (rowfound != null)
            {
                rowfound["ProductName"] = updatedProduct.ProductName;
                rowfound["SupplierID"] = updatedProduct.SupplierID;
                rowfound["CategoryID"] = updatedProduct.CategoryID;
                rowfound["QuantityPerUnit"] = updatedProduct.QuantityPerUnit;
                rowfound["UnitPrice"] = updatedProduct.UnitPrice;
                rowfound["UnitsInStock"] = updatedProduct.UnitsInStock;
                rowfound["UnitsOnOrder"] = updatedProduct.UnitsOnOrder;
                rowfound["ReorderLevel"] = updatedProduct.ReorderLevel;
                rowfound["Discontinued"] = updatedProduct.Discontinued;
                SqlCommandBuilder bldr = new SqlCommandBuilder(da_products);
                int rowsAffected = da_products.Update(dsNw, "Products");

                bool status = false;
                if (rowsAffected > 0)
                {
                    status = true;
                }
                return status;
            }
            else
            {
                throw new Exception("Product ID doesn't exists");
            }
        }

        public Products SearchProductByID(int id) 
        {
            DataRow rowfound = dt.Rows.Find(id);
            if (rowfound != null)
            {
                Products product = new Products();
                product.ProductID = Convert.ToInt32(rowfound["ProductID"]);
                product.ProductName = rowfound["ProductName"].ToString();
                product.SupplierID = Convert.ToInt32(rowfound["SupplierID"]);
                product.CategoryID = Convert.ToInt32(rowfound["CategoryID"]);
                product.QuantityPerUnit = rowfound["QuantityPerUnit"].ToString();
                product.UnitPrice = Convert.ToDecimal(rowfound["UnitPrice"]);

                product.UnitsInStock = Convert.ToInt16(rowfound["UnitsInStock"]);
                product.UnitsOnOrder = Convert.ToInt16(rowfound["UnitsOnOrder"]);
                product.ReorderLevel = Convert.ToInt16(rowfound["ReorderLevel"]);
                product.Discontinued = Convert.ToBoolean(rowfound["Discontinued"]);
                
                return product;
            }
            else
            {
                throw new Exception("Product ID doesn't exists");
            }



        }
        public Products SearchProductByName(string prodname) 
        {
            DataTable dt = dsNw.Tables["Products"];
            var rowfound = dt.AsEnumerable().Where(p => p.Field<string>("ProductName") == prodname).FirstOrDefault();

            //var rowfound = (from row in dt.AsEnumerable()
            //              where row.Field<string>("ProductName") == prodname
            //              select row).FirstOrDefault();
            if (rowfound != null) 
            {
                Products product = new Products();
                product.ProductID = Convert.ToInt32(rowfound["ProductID"]);
                product.ProductName = rowfound["ProductName"].ToString();
                product.SupplierID = Convert.ToInt32(rowfound["SupplierID"]);
                product.CategoryID = Convert.ToInt32(rowfound["CategoryID"]);
                product.QuantityPerUnit = rowfound["QuantityPerUnit"].ToString();
                product.UnitPrice = Convert.ToDecimal(rowfound["UnitPrice"]);

                product.UnitsInStock = Convert.ToInt16(rowfound["UnitsInStock"]);
                product.UnitsOnOrder = Convert.ToInt16(rowfound["UnitsOnOrder"]);
                product.ReorderLevel = Convert.ToInt16(rowfound["ReorderLevel"]);
                product.Discontinued = Convert.ToBoolean(rowfound["Discontinued"]);
            return product;
            
            
            }
            else
            {
                throw new Exception("Product ID doesn't exists");
            }
        

        }
    }
}
