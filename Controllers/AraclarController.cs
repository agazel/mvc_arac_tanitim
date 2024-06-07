using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OdevProje.Models;

namespace OdevProje.Controllers
{
    public class AraclarController : Controller
    {
        private readonly AppDbContext _context;

        public AraclarController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {
                var araclarListesi = _context.Araclar.ToList();
                return View(araclarListesi);
            }
            catch (Exception ex)
            {
                // Hata ayrıntılarını loglama veya debug amaçlı çıktıya yazma
                Debug.WriteLine($"Hata: {ex.Message}");

                // Hata sayfasına yönlendirme veya uygun bir işlem
                return View("Error");
            }
        }
    }
}
