using eCommerce.Models;
using eCommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers;

public class CartsController : Controller
{
    private readonly ICommonRepository<Cart> _cartRepository;
    private readonly ICommonRepository<CartItem> _cartItemRepository;
    private readonly ICartRepository _cartViewRepository;
    public CartsController(ICommonRepository<Cart> cartRepository, ICommonRepository<CartItem> cartItemRepository, ICartRepository cartViewRepository)
    {
        _cartRepository = cartRepository;
        _cartItemRepository = cartItemRepository;
        _cartViewRepository = cartViewRepository;
    }

    public IActionResult Index()
    {
        return View();
    }
    public async Task<IActionResult> AddToCart(int productId)
    {
        if (HttpContext.Session.GetInt32("CartId")<=0|| HttpContext.Session.GetInt32("CartId")==null)
        {
            Cart cart = new Cart() { CartDate = DateTime.Now, CustomerId = 1 };
            int result = await _cartRepository.InsertAsync(cart);
            HttpContext.Session.SetInt32("CartId", cart.CartId);
        }
        int cartItemResult = await _cartItemRepository.InsertAsync(new CartItem()
        {
            ProductId=productId,
            Quantity=1,
            CartId= Convert.ToInt32(HttpContext.Session.GetInt32("CartId"))
        });

        return RedirectToAction("YourCart");
    }
    
    public async Task<IActionResult> YourCart()
    {
        var result = await _cartViewRepository.GetCartItems(Convert.ToInt32(HttpContext.Session.GetInt32("CartId")));
        return View(result);
    }
}
