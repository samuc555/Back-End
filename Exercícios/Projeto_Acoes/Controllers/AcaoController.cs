using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_Acoes.Context;
using Projeto_Acoes.Models;

namespace Projeto_Acoes.Controllers
{
    public class AcaoController : Controller
    {
        private readonly AppDbContext _context;

        public AcaoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Acao
        public async Task<IActionResult> Index()
        {
              return _context.Acoes != null ? 
                          View(await _context.Acoes.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Acoes'  is null.");
        }

        // GET: Acao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Acoes == null)
            {
                return NotFound();
            }

            var acao = await _context.Acoes
                .FirstOrDefaultAsync(m => m.AcaoId == id);
            if (acao == null)
            {
                return NotFound();
            }

            return View(acao);
        }

        // GET: Acao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Acao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AcaoId,Codigo,Empresa,Logo,Valor")] Acao acao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(acao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(acao);
        }

        // GET: Acao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Acoes == null)
            {
                return NotFound();
            }

            var acao = await _context.Acoes.FindAsync(id);
            if (acao == null)
            {
                return NotFound();
            }
            return View(acao);
        }

        // POST: Acao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AcaoId,Codigo,Empresa,Logo,Valor")] Acao acao)
        {
            if (id != acao.AcaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(acao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcaoExists(acao.AcaoId))
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
            return View(acao);
        }

        // GET: Acao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Acoes == null)
            {
                return NotFound();
            }

            var acao = await _context.Acoes
                .FirstOrDefaultAsync(m => m.AcaoId == id);
            if (acao == null)
            {
                return NotFound();
            }

            return View(acao);
        }

        // POST: Acao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Acoes == null)
            {
                return Problem("Entity set 'AppDbContext.Acoes'  is null.");
            }
            var acao = await _context.Acoes.FindAsync(id);
            if (acao != null)
            {
                _context.Acoes.Remove(acao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AcaoExists(int id)
        {
          return (_context.Acoes?.Any(e => e.AcaoId == id)).GetValueOrDefault();
        }
    }
}
