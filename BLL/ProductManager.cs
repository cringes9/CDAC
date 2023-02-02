namespace BLL;
using BOL;
using DAL;
using System.Collections.Generic;

public class ProductManager
{
    public static ProductManager _ref=null;
    private ProductManager()
    {

    }
    public static ProductManager GetProductManager(){
        if(_ref==null){
            _ref=new ProductManager();
        }
        return _ref;

    }
    public List<Product>GetAllProducts()
    {
        var products= ProductsRepository.GetAll();
        return products;
    }
    public List<Product> GetSoldOut()
    {
        List<Product> products=ProductsRepository.GetAll();
       var soldOutProducts = from prod in products
                                where prod.StockAvailable == 0
                                select prod;
                                return ( List<Product> )soldOutProducts;
    }
     public  List<Product> GetProuductsInStockLessthan(int amount)
    {
        List<Product> products=ProductsRepository.GetAll();
        var getProuducts=from prod in products where prod.StockAvailable > 0 && prod.UnitPrice > amount
                            select prod;
                            return getProuducts as List<Product>;
    }
    public  List<string> GetProductsTitle()
    {
        List<Product> products = GetAllProducts();
        var productNames =from prod in products
                            select prod.Title;
        return productNames as List<string>;
    }
      public  List<Product> GetProductsOrderby()
    {
        List<Product> products = GetAllProducts();
        var sortedProducts = from prod in products
                              orderby prod.Title
                              select prod;
        return sortedProducts as List<Product>;
    } 
        public  List<string> GetProductsDistinct()
    {
        List<Product> products = GetAllProducts();
        var categoryNames = ( from prod in products
                               select prod.Category
                            ).Distinct();
        return categoryNames as List<string>;
    }
 public Product GetProductById(int id){
        Product product=ProductsRepository.GetById(id);
        return product;
    }

}
