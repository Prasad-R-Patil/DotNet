using eCommerce.Models;

namespace eCommerce.Repositories;

public interface ICartRepository
{
    Task<List<CartViewModel>> GetCartItems(int cartId);
}
