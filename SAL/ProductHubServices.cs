namespace SAL;
using BOL;
using BLL;
public static class ProductHubServices
{
    public static List<Product> GetAllProducts(){
        ProductManager theManager=ProductManager.GetProductManager();
        List<Product> allProducts=theManager.GetAllProducts();
        return allProducts;
         
    }
    public static Product GetProductById(int id)
    {
          ProductManager theManager=ProductManager.GetProductManager();
          Product p=theManager.GetProductById(id);
          return p;
    }
}