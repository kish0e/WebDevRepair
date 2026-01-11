public class Warehouse
{
    public int Id { get; set; }
    public string Location { get; set; }
    public int Capacity { get; set; }
    public string PasswordHash { get; set; }
    public List<Inventory> Inventories { get; set; }
}