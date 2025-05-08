
namespace MAUILearningKit.Models;

public class Order
{
    public int OrderID { get; set; }
    public required string CustomerID { get; set; }
    public required string ShipCountry { get; set; }
    public required string ShipName { get; set; }
    public required DateTime OrderDate { get; set; }
}