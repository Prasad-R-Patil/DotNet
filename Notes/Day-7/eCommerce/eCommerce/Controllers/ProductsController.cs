using eCommerce.Models;
using eCommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers;

public class ProductsController : Controller
{
    private readonly ICommonRepository<Product> _productsRepository;

    public ProductsController(ICommonRepository<Product> productsRepository)
    {
        _productsRepository = productsRepository;
    }

    public async Task<IActionResult> Index()
    {
        ViewBag.PageTitle = "ECommerce Products List!";
        var products = await _productsRepository.GetAllAsync();
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
