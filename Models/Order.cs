using System.ComponentModel.DataAnnotations;
namespace StoreApi.Models
{
  public class Order
  {
    [Key]
    public int order_id { get; set; }
    public int quantity { get; set; }
    public int customer_id { get; set; }
    public int product_id { get; set; }
    public int shipper_id { get; set; }
  }
}