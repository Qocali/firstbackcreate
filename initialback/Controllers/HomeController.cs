using initialback.DAL;
using initialback.Models;
using initialback.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace initialback.Controllers
{
    public class HomeController : Controller
    {
       private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;    
        }
        public IActionResult Index()
        {
            HomeVM vm = new HomeVM
            {
                Slider = _db.Sliders.FirstOrDefault(),
                Sliderimage = _db.SliderImages.ToList(),
                About=_db.Abouts.FirstOrDefault(),
                Icon=_db.Icons.ToList(),
                Florishe=_db.Florishes.ToList(),
                FlorishType=_db.FlorishType.ToList()
            };
            return View(vm);
        }

        
    }
}
