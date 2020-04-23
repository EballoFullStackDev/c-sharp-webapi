using System.ComponentModel.DataAnnotations;
namespace StoreApi.Models
{
  public class Product
  {
    [Key]
    public int product_id { get; set; }
    public string item_name { get; set; }
    public double price { get; set; }
    public bool in_stock { get; set; }
  }
}