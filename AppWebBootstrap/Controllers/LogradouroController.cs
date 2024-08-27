using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppWebBootstrap.Data;
using AppWebBootstrap.Models;

namespace AppWebBootstrap.Controllers
{
    public class LogradouroController : Controller
    {
        private readonly AppWebBootstrapContext _context;

        public LogradouroController(AppWebBootstrapContext context)
        {
            _context = context;
        }

        // GET: Logradouro
        public async Task<IActionResult> Index()
        {
            return View(await _context.Logradouro.ToListAsync());
        }

        // GET: Logradouro/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logradouro = await _context.Logradouro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (logradouro == null)
            {
                return NotFound();
            }

            return View(logradouro);
        }

        // GET: Logradouro/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Logradouro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cep,Endereco,Numero,Cidade,Estado,Pais,Id")] Logradouro logradouro)
        {
            if (ModelState.IsValid)
            {
                logradouro.Id = Guid.NewGuid();
                _context.Add(logradouro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(logradouro);
        }

        // GET: Logradouro/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logradouro = await _context.Logradouro.FindAsync(id);
            if (logradouro == null)
            {
                return NotFound();
            }
            return View(logradouro);
        }

        // POST: Logradouro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Cep,Endereco,Numero,Cidade,Estado,Pais,Id")] Logradouro logradouro)
        {
            if (id != logradouro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(logradouro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LogradouroExists(logradouro.Id))
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
            return View(logradouro);
        }

        // GET: Logradouro/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logradouro = await _context.Logradouro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (logradouro == null)
            {
                return NotFound();
            }

            return View(logradouro);
        }

        // POST: Logradouro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var logradouro = await _context.Logradouro.FindAsync(id);
            _context.Logradouro.Remove(logradouro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LogradouroExists(Guid id)
        {
            return _context.Logradouro.Any(e => e.Id == id);
        }
    }
}
