using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using RoasterWebApplication.Models;

namespace RoasterWebApplication.Controllers
{
    public class RosterController : Controller
    {
        private readonly RosterDBContext _context;

        public RosterController(RosterDBContext context)
        {
            _context = context;
          
        }
  
        public async Task<IActionResult> Index()
        {
            return View(await _context.Members.ToListAsync());
        }

        [HttpGet]
        public IActionResult GetRoaster()
        {
            var res = _context.Members.Where(x => x.GroupName == "Avenger");
            return Ok(res);
        }
    }
}
