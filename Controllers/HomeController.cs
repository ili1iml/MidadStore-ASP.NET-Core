using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MidadStore.Models;

namespace MidadStore.Controllers;

public class HomeController : Controller
{
    private static  dynamic[]  _categories = 
{ 
    new { Id = 0, Name = "الألوان", Icon = "bi bi-palette" }, 
    new { Id = 1, Name = "فرش الرسم", Icon = "bi bi-brush" }, 
    new { Id = 2, Name = "الكراسات", Icon = "bi bi-journal" } 
};
  private static dynamic[] _products = new dynamic[]
{
    // 🎨 قسم الألوان (CategoryId = 0)
    new { Id = 101, CategoryId = 0, Name = "مجموعة ألوان أكريليك احترافية", Price = 85, Image = "acrylic_set.jpg" },
    new { Id = 102, CategoryId = 0, Name = "ألوان مائية أنابيب توب", Price = 60, Image = "watercolor_tubes.jpg" },
    new { Id = 103, CategoryId = 0, Name = "ألوان غواش صناديق", Price = 45, Image = "gouache_box.jpg" },

    // 🖌️ قسم فرش وسكاكين رسم (CategoryId = 1)
    new { Id = 201, CategoryId = 1, Name = "مجموعة فرش دائرية ناعمة (6 قطع)", Price = 35, Image = "brushes_set.jpg" },
    new { Id = 202, CategoryId = 1, Name = "سكاكين رسم ستيل بمقابض خشبية", Price = 25, Image = "palette_knives.jpg" },
    new { Id = 203, CategoryId = 1, Name = "فرشاة دمج عريضة (Mop Brush)", Price = 18, Image = "mop_brush.jpg" },

    // 📓 قسم كراسات ولوحات (CategoryId = 2)
    new { Id = 301, CategoryId = 2, Name = "كراسة رسم ورق كانسون 300 جرام", Price = 40, Image = "canson_sketchbook.jpg" },
    new { Id = 302, CategoryId = 2, Name = "لوحة كانفاس مشدودة 40×40 سم", Price = 20, Image = "canvas_stretched.jpg" },
    new { Id = 303, CategoryId = 2, Name = "دفتر اسكتش للرسم الحر والتظليل", Price = 15, Image = "sketchbook_tonal.jpg" }
};
    public IActionResult Products(int id)
    {
        var filtered = _products
        .Where(p => p.CategoryId == id)
        .ToList();
        ViewBag.FilteredProducts = filtered;
        ViewBag.CategoryName = _categories[id];
        return View();
    }
    public IActionResult Index()
    {
        ViewBag.CategoriesList = _categories;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
