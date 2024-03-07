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
    public class ProcedursController : Controller
    {
        private readonly MedBaseContext _context;

        public ProcedursController(MedBaseContext context)
        {
            _context = context;
        }

        // GET: Procedurs
        public async Task<IActionResult> Index()
        {
              return _context.Procedurs != null ? 
                          View(await _context.Procedurs.ToListAsync()) :
                          Problem("Entity set 'MedBaseContext.Procedurs'  is null.");
        }

        // GET: Procedurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Procedurs == null)
            {
                return NotFound();
            }

            var procedur = await _context.Procedurs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (procedur == null)
            {
                return NotFound();
            }

            return View(procedur);
        }

        // GET: Procedurs/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("/ProcedursController/Create")]
        public async Task<IActionResult> Create([FromBody] Procedur procedur)
        {

            var toChek = _context.Pacients.Where(op => procedur.Id == procedur.Id).FirstOrDefault();

            Procedur create = new()
            {
                TypeProcedure = procedur.TypeProcedure,
               Procedure = procedur.Procedure,
                Date = procedur.Date,
                Doctor = procedur.Doctor


            };
            await _context.Procedurs.AddAsync(create);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                StatusCode = 200
            });


        }

        // GET: Procedurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Procedurs == null)
            {
                return NotFound();
            }

            var procedur = await _context.Procedurs.FindAsync(id);
            if (procedur == null)
            {
                return NotFound();
            }
            return View(procedur);
        }

        // POST: Procedurs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdPacient,TypeProcedure,Procedure,Date,Doctor")] Procedur procedur)
        {
            if (id != procedur.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(procedur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcedurExists(procedur.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(procedur);
        }

        // GET: Procedurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Procedurs == null)
            {
                return NotFound();
            }

            var procedur = await _context.Procedurs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (procedur == null)
            {
                return NotFound();
            }

            return View(procedur);
        }

        // POST: Procedurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Procedurs == null)
            {
                return Problem("Entity set 'MedBaseContext.Procedurs'  is null.");
            }
            var procedur = await _context.Procedurs.FindAsync(id);
            if (procedur != null)
            {
                _context.Procedurs.Remove(procedur);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcedurExists(int id)
        {
          return (_context.Procedurs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
