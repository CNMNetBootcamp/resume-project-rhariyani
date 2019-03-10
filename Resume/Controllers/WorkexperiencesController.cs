using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Resume.Data;
using Resume.Models;

namespace Resume.Controllers
{
    public class WorkexperiencesController : Controller
    {
        private readonly ResumeContext _context;

        public WorkexperiencesController(ResumeContext context)
        {
            _context = context;
        }

        // GET: Workexperiences
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var workexperiences = _context.Workexperience.Include(w => w.Job);
               
            return View(await workexperiences.ToListAsync());
        }

        // GET: Workexperiences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workexperience = await _context.Workexperience
                .Include(w => w.Job)
                .SingleOrDefaultAsync(m => m.ID == id);
            ViewData["JobID"] = new SelectList(_context.Job, "ID", "Company");

            if (workexperience == null)
            {
                return NotFound();
            }

            return View(workexperience);
        }

        // GET: Workexperiences/Create
        public IActionResult Create()
        {
            ViewData["JobID"] = new SelectList(_context.Job, "ID", "Company");

            return View();
        }

        // POST: Workexperiences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ExperieceDescription,WorkId,JobID")] Workexperience workexperience)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workexperience);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           ViewData["JobID"] = new SelectList(_context.Job, "ID", "Company", workexperience.JobID);
            return View(workexperience);
        }

        // GET: Workexperiences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workexperience = await _context.Workexperience.SingleOrDefaultAsync(m => m.ID == id);
            if (workexperience == null)
            {
                return NotFound();
            }
            ViewData["JobID"] = new SelectList(_context.Job, "ID", "Company", workexperience.JobID);
            return View(workexperience);
        }

        // POST: Workexperiences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ExperieceDescription,WorkId,JobID")] Workexperience workexperience)
        {

            if (id != workexperience.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workexperience);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkexperienceExists(workexperience.ID))
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
          ViewData["JobID"] = new SelectList(_context.Job, "ID", "Company", workexperience.JobID);
            return View(workexperience);
        }

        // GET: Workexperiences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workexperience = await _context.Workexperience
                .Include(w => w.Job)
                .SingleOrDefaultAsync(m => m.ID == id);
            if (workexperience == null)
            {
                return NotFound();
            }
            


            return View(workexperience);
        }

        // POST: Workexperiences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workexperience = await _context.Workexperience.SingleOrDefaultAsync(m => m.ID == id);
            _context.Workexperience.Remove(workexperience);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkexperienceExists(int id)
        {
            return _context.Workexperience.Any(e => e.ID == id);
        }
    }
}
