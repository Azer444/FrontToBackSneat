using Front_to_back_sneat.Data;
using Front_to_back_sneat.Models;
using Front_to_back_sneat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back_sneat.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
       

        public async Task<IActionResult> Index()
        {

            IEnumerable<Slider> sliders = await _context.Sliders.ToListAsync();

            IEnumerable<Work> works = await _context.Works.Take(6).ToListAsync();

            SliderImage sliderImage = await _context.SliderImages.FirstAsync();

            IEnumerable<Service> services = await _context.Services.ToListAsync();

        



            HomeVM model = new HomeVM
            {
                Sliders = sliders,
                SliderImage = sliderImage,
                Works = works,
                Services = services

            };

            return View(model);

        }

    }
}
