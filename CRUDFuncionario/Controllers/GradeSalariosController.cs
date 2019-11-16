using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUDFuncionario.Models;

namespace CRUDFuncionario.Controllers
{
    public class GradeSalariosController : Controller
    {
        private readonly GradeSalarioContext _context;

        public GradeSalariosController(GradeSalarioContext context)
        {
            _context = context;
        }

        // GET: GradeSalarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.GradeSalarios.ToListAsync());
        }

        // GET: GradeSalarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gradeSalario = await _context.GradeSalarios
                .FirstOrDefaultAsync(m => m.Id_salario == id);
            if (gradeSalario == null)
            {
                return NotFound();
            }

            return View(gradeSalario);
        }

        // GET: GradeSalarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GradeSalarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_salario,Min_salario,Max_salario,Fg_ativo")] GradeSalario gradeSalario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gradeSalario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gradeSalario);
        }

        // GET: GradeSalarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gradeSalario = await _context.GradeSalarios.FindAsync(id);
            if (gradeSalario == null)
            {
                return NotFound();
            }
            return View(gradeSalario);
        }

        // POST: GradeSalarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_salario,Min_salario,Max_salario,Fg_ativo")] GradeSalario gradeSalario)
        {
            if (id != gradeSalario.Id_salario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gradeSalario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GradeSalarioExists(gradeSalario.Id_salario))
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
            return View(gradeSalario);
        }

        // GET: GradeSalarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gradeSalario = await _context.GradeSalarios
                .FirstOrDefaultAsync(m => m.Id_salario == id);
            if (gradeSalario == null)
            {
                return NotFound();
            }

            return View(gradeSalario);
        }

        // POST: GradeSalarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gradeSalario = await _context.GradeSalarios.FindAsync(id);
            _context.GradeSalarios.Remove(gradeSalario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GradeSalarioExists(int id)
        {
            return _context.GradeSalarios.Any(e => e.Id_salario == id);
        }
    }
}
