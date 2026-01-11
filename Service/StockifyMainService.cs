public class StockifyMainService : IStockifyMainService
{

    private readonly StockifyContext _context;
    public StockifyMainService(StockifyContext context)
    {
        _context = context;
    }   

    public Inventory AddProductToInventory(int productId, int warehouseId, int quantity)
    {
        throw new NotImplementedException();
    }

    public Product CreateProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public bool DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public Admin? GetAdminUser(string username, string password)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public Product? GetProductById(int id)
    {
        throw new NotImplementedException();
    }

    public Warehouse GetWarehouseUser(string location, string password)
    {
        throw new NotImplementedException();
    }

    public Inventory UpdateInventory(int productId, int warehouseId, int quantity)
    {
        throw new NotImplementedException();
    }

    public Product? UpdateProduct(int id, Product updatedProduct)
    {
        throw new NotImplementedException();
    }
}