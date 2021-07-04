using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShirtAppMVC.Models;
using ShirtAppMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;



namespace ShirtAppMVC.Controllers
{
    public class BrowseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BrowseController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Browse()
        {
            return View(await _context.Shirts.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shirt = await _context.Shirts
                .FirstOrDefaultAsync(m => m.ShirtID == id);
            if (shirt == null)
            {
                return NotFound();
            }

            return View(shirt);
        }
    }
}
