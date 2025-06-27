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

    private int GetCartId()
    {
        var cartId = HttpContext.Session.GetInt32("CartId");
        return cartId.HasValue ? cartId.Value : 0;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddToCart(int productId, int quantity)
    {
        int cartId = GetCartId();

        if (cartId <= 0)
        {
            var cart = new Cart { CartDate = DateTime.Now, CustomerId = 1 };
            await _cartRepository.InsertAsync(cart);
            HttpContext.Session.SetInt32("CartId", cart.CartId);
            cartId = cart.CartId;
        }

        var cartItems = await _cartItemRepository.GetAllAsync();
        var existingItem = cartItems.FirstOrDefault(c => c.CartId == cartId && c.ProductId == productId);

        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
            await _cartItemRepository.UpdateAsync(existingItem);
        }
        else
        {
            await _cartItemRepository.InsertAsync(new CartItem
            {
                CartId = cartId,
                ProductId = productId,
                Quantity = quantity
            });
        }

        HttpContext.Session.SetInt32("CartCount", cartItems.Where(c => c.CartId == cartId).Sum(c => c.Quantity) + quantity);
        return RedirectToAction("YourCart");
    }


    public async Task<IActionResult> YourCart()
    {
        int cartId = GetCartId();

        var result = await _cartViewRepository.GetCartItems(cartId);
        HttpContext.Session.SetInt32("CartCount", result.Sum(x => x.Quantity));

        return View(result);
    }

    public async Task<IActionResult> RemoveFromCart(int productId)
    {
        int cartId = GetCartId();

        var items = await _cartItemRepository.GetAllAsync();
        var toRemove = items.FirstOrDefault(ci => ci.ProductId == productId && ci.CartId == cartId);

        if (toRemove != null)
            await _cartItemRepository.DeleteAsync(toRemove.CartItemId);

        return RedirectToAction("YourCart");
    }
}
