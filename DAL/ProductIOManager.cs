namespace DAL;
using BOL;
using System.Text.Json;
using System.IO;
public static class ProductsRepository
{
    public static List<Product> GetAll()
    {
       string restored =File.ReadAllText(@"D:\Dot Net Core\Web MVC\Test\products.json");
     List<Product> restoredProducts=JsonSerializer.Deserialize<List<Product>>(restored);
     return restoredProducts;

    }
    public static Product GetById(int id)
    {
        List<Product> products=GetAll();
        var theProduct= from pro in products where pro.ProductId==id select pro; 
          return theProduct.First<Product>();
    }
    public static bool Insert(Product p)
    {
        bool status=false;
        List<Product> products=GetAll();//Inserting into list of products with parameter Product p
        products.Add(p);
              string jsonString=JsonSerializer.Serialize(products);
              File.WriteAllText(@"D:\Dot Net Core\Web MVC\Test\products.json",jsonString);
        status=true;
        return status;
    }
     public static bool Delete(int id)
    {
        bool status=false;
        List<Product> products=GetAll();
        products.Remove(GetById(id));//Removing through Get By Id will get the respective Product 
         string jsonString=JsonSerializer.Serialize(products);
              File.WriteAllText(@"D:\Dot Net Core\Web MVC\Test\products.json",jsonString);
        status=true;
        return status;
    } 
       public static bool Update(Product p)
    {
        bool status=false;
        List<Product> products=GetAll();
         string jsonString=JsonSerializer.Serialize(products);
              File.WriteAllText(@"D:\Dot Net Core\Web MVC\Test\products.json",jsonString);
        
      
     
        status=true;
        return status;
    } 
    

}   
