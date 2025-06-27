
using eCommerce.Dal;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace eCommerce.Repositories;

public class CartRepository : ICartRepository
{
    private readonly ECommerceDbContext _context;

    public CartRepository(ECommerceDbContext context)
    {
        _context = context;
    }

    public async Task<List<CartViewModel>> GetCartItems(int cartId)
    {
        var query = from cart in _context.Carts
                    join
                    cartItem in _context.CartItems
                    on cart.CartId equals cartItem.CartId
                    join
                    product in _context.Products
                    on cartItem.ProductId equals product.ProductId
                    join
                    category in _context.Categories
                    on product.CategoryId equals category.CategoryId
                    where cart.CartId == cartId
                    select new CartViewModel
                    {
                        CategoryName = category.CategoryName,
                        ProductName = product.ProductName,
                        Picture = product.Picture,
                        Quantity = cartItem.Quantity,
                        UnitPrice = product.UnitPrice,
                        Discount = product.Discount,
                        TotalAmount = (product.UnitPrice - (product.UnitPrice * product.Discount / 100)) * cartItem.Quantity
                    };

        return await query.ToListAsync();

    }
}
