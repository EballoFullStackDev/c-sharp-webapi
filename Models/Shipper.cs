using System.ComponentModel.DataAnnotations;
namespace StoreApi.Models
{
  public class Shipper
  {
    [Key]
    public int shipper_id { get; set; }
    public string shipper_name { get; set; }
    public string phone { get; set; }
  }
}