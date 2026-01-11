using Microsoft.AspNetCore.Mvc;

[Route("api/")]
public class StockifyController : Controller
{
    private readonly IStockifyMainService _service;
    public StockifyController(IStockifyMainService service)
    {
        _service = service;
    }

    [HttpGet("status")]
    public IActionResult GetStatus()
    {
        return Ok(new { status = "Stockify API is running." });
    }

    [HttpPost("login/admin")]
    public IActionResult AdminLogin()
    {
        throw new NotImplementedException();
    }

    [HttpDelete("logout")]
    public IActionResult Logout()
    {
        throw new NotImplementedException();
    }

    [HttpGet("loginstatus/admin")]
    public IActionResult GetAdminLoginStatus()
    {
        throw new NotImplementedException();
    }

    [HttpPost("products")]
    public IActionResult CreateProduct()
    {
        throw new NotImplementedException();
    }

    [HttpGet("products")]
    public IActionResult GetProducts()
    {
        throw new NotImplementedException();
    }

    [HttpGet("products/{id}")]
    public IActionResult GetProductById(int id)
    {
        throw new NotImplementedException();
    }

    [HttpPut("products/{id}")]
    public IActionResult UpdateProduct(int id)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("products/{id}")]
    public IActionResult DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    [HttpPost("login/warehouse")]
    public IActionResult WarehouseLogin()
    {
        throw new NotImplementedException();
    }

    [HttpGet("loginstatus/warehouse")]
    public IActionResult GetWarehouseLoginStatus()
    {
        throw new NotImplementedException();
    }

    [HttpPut("inventory")]
    public IActionResult UpdateInventory()
    {
        throw new NotImplementedException();
    }

    [HttpPost("inventory")]
    public IActionResult AddProductToInventory()
    {
        throw new NotImplementedException();
    }

    

}