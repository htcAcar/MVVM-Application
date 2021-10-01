
namespace StartApp.Entities.Dtos
{
    public class ProductDto
    {
         public int ProductID { get; set; }
         public string ProductName { get; set; }
         public string CompanyName { get; set; }
         public string Category { get; set; }
         public int SupplierID { get; set; }
         public int CategoryID { get; set; }
         public string QuantityPerUnit { get; set; }
         public decimal UnitPrice { get; set; }        
    }
}
