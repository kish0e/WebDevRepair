public interface IStockifyMainService
{
    Admin? GetAdminUser(string username, string password);
    Product CreateProduct(Product product);
    IEnumerable<Product> GetAllProducts();
    Product? GetProductById(int id);
    Product? UpdateProduct(int id, Product updatedProduct);
    bool DeleteProduct(int id);
    Warehouse GetWarehouseUser(string location, string password);
    Inventory UpdateInventory(int productId, int warehouseId, int quantity);
    Inventory AddProductToInventory(int productId, int warehouseId, int quantity);
}