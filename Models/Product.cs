public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int SupplierId { get; set; }
    public Supplier Supplier { get; set; }
    public List<Inventory> Inventories { get; set; }
}