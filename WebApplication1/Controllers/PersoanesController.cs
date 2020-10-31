using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersoanesController : ControllerBase
    {
        private readonly GhiseuDigitalContext _context;

        public PersoanesController(GhiseuDigitalContext context)
        {
            _context = context;
        }

        // GET: Persoanes
        //public async Task<IActionResult> Index()
        //{
        //    //return View(await _context.Persoane.ToListAsync());
        //}

        //// GET: Persoanes/Details/5
        //public Persoane Details(string id)
        //{
        //    Persoane p = new Persoane();

        //    if (id == null)
        //    {
        //        return p;
        //    }

        //    var persoane = _context.Persoane
        //        .FirstOrDefaultAsync(m => m.Cnp == id);
        //    if (persoane == null)
        //    {
        //        return new Persoane();
        //    }

        //    p = persoane.Result;

        //    return p;
        //    //return View(persoane);
        //}

        ////// GET: Persoanes/Create
        //public IActionResult Create()
        //{
        //  //  return View();
        //}

        //// POST: Persoanes/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Cnp,Nume,Prenume,Serie,Numar,Adresa,DataNasterii,StatusPolitie,StatusMedic,StatusUniversitate")] Persoane persoane)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(persoane);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //  //  return View(persoane);
        //}

        //// GET: Persoanes/Edit/5
        //public async Task<IActionResult> Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var persoane = await _context.Persoane.FindAsync(id);
        //    if (persoane == null)
        //    {
        //        return NotFound();
        //    }
        //  //  return View(persoane);
        //}

        //// POST: Persoanes/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(string id, [Bind("Cnp,Nume,Prenume,Serie,Numar,Adresa,DataNasterii,StatusPolitie,StatusMedic,StatusUniversitate")] Persoane persoane)
        //{
        //    if (id != persoane.Cnp)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(persoane);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PersoaneExists(persoane.Cnp))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //   // return View(persoane);
        //}

        //// GET: Persoanes/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var persoane = await _context.Persoane
        //        .FirstOrDefaultAsync(m => m.Cnp == id);
        //    if (persoane == null)
        //    {
        //        return NotFound();
        //    }

        //  //  return View(persoane);
        //}

        //// POST: Persoanes/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var persoane = await _context.Persoane.FindAsync(id);
        //    _context.Persoane.Remove(persoane);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool PersoaneExists(string id)
        //{
        //    return _context.Persoane.Any(e => e.Cnp == id);
        //}
    }
}
