using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using API;

namespace API.Controllers
{
    public class GospitalisationsController : Controller
    {
        private readonly MedBaseContext _context;

        public GospitalisationsController(MedBaseContext context)
        {
            _context = context;
        }

        // GET: Gospitalisations
        public async Task<IActionResult> Index()
        {
            return _context.Gospitalisations != null ?
                        View(await _context.Gospitalisations.ToListAsync()) :
                        Problem("Entity set 'MedBaseContext.Gospitalisations'  is null.");
        }

        // GET: Gospitalisations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Gospitalisations == null)
            {
                return NotFound();
            }

            var gospitalisation = await _context.Gospitalisations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gospitalisation == null)
            {
                return NotFound();
            }

            return View(gospitalisation);
        }

        // GET: Gospitalisations/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("/GospitalisationsController/Create")]
        public async Task<IActionResult> Create([FromBody] Gospitalisation gospitalisation)
        {

            var toChek = _context.Pacients.Where(op => gospitalisation.Id == gospitalisation.Id).FirstOrDefault();

            Gospitalisation create = new()
            {
                PolisNumber = gospitalisation.PolisNumber,
                PolisCompany = gospitalisation.PolisCompany,
                PolisStart = gospitalisation.PolisStart,
                PolisEnd = gospitalisation.PolisEnd,
                Diagnos = gospitalisation.Diagnos,
                Status =   gospitalisation.Status
            };
            await _context.Gospitalisations.AddAsync(create);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                StatusCode = 200
            });
        }


    }
    
}
