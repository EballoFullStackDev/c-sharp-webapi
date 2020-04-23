using System.ComponentModel.DataAnnotations;
namespace StoreApi.Models
{
  public class Customer
  {
    [Key]
    public int customer_id { get; set; }
    public string contact_name { get; set; }
    public string address { get; set; }
    public string city { get; set; }
    public int postal_code { get; set; }
    public string country { get; set; }
    public string phone { get; set; }
  }
}