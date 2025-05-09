
namespace MAUILearningKit.Models;

public class Order
{
    public int OrderID { get; set; }
    public required string ?CustomerID { get; set; }
    public required int ?EmployeeID { get; set; }
    public required DateTime ?OrderDate { get; set; }
    public required DateTime ?RequiredDate { get; set; }
    public required string ?ShipAddress { get; set; }
    public required string ?ShipCity { get; set; }
    public required string ?ShipCountry { get; set; }
    public required string ?ShipName { get; set; }
    public required string ?ShipPostalCode { get; set; }
    public required string ?ShipRegion { get; set; }
    public required int ?ShipVia { get; set; }
    public required DateTime ?ShippedDate { get; set; }
}