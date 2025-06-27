using eCommerce.Models;
using eCommerce.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace eCommerce.Controllers;

public class ProductsController : Controller
{
    private readonly ICommonRepository<Product> _productsRepository;
    private readonly IMemoryCache _productsCache;
    public ProductsController(ICommonRepository<Product> productsRepository, IMemoryCache productsCache)
    {
        _productsRepository = productsRepository;
        _productsCache = productsCache;
    }

    public async Task<IActionResult> Index()
    {
        ViewBag.PageTitle = "ECommerce Products List!";

        if (!_productsCache.TryGetValue("ProductsCache", out List<Product> products))
        {
            products = await _productsRepository.GetAllAsync();
            var cacheOptions = new MemoryCacheEntryOptions();
            cacheOptions.AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(10);
            cacheOptions.SlidingExpiration = new TimeSpan(5);
            _productsCache.Set("ProductsCache", products, cacheOptions);
        }

        return View(products);
    }
    public async Task<IActionResult> Details(int id)
    {
       
        var product = await _productsRepository.GetDetailsAsync(id);
        return View(product);
    }
    public async Task<IActionResult> CategoryWiseProducts(int id)
    {
        ViewBag.PageTitle = "ECommerce Products List!";
        var products = await _productsRepository.GetAllAsync();
        return View("Index", products.Where(p => p.CategoryId == id));
    }
}
