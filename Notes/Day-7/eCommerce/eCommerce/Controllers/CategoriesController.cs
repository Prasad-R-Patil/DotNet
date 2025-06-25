using eCommerce.Models;
using eCommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers;

public class CategoriesController : Controller
{
    private readonly ICommonRepository<Category> _categoryRepository;

    public CategoriesController(ICommonRepository<Category> categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<IActionResult> Index()
    {
        ViewBag.PageTitle = "eCommerce Categories List!";
        var categories = await _categoryRepository.GetAllAsync();
        return View(categories);
    }
}
