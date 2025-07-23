using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TechTreeMVCApplication.Data;
using TechTreeMVCApplication.Entities;

namespace TechTreeMVCApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriaItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriaItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/CategoriaItem
        public async Task<IActionResult> Index(int categoriaId)
        {
            //catItem es una abreviacion de categoriaItem
            List<CategoriaItem> list = await (from catItem in _context.CategoriasItem
                                              where catItem.CategoriaId == categoriaId
                                              select new CategoriaItem
                                              {
                                                  Id = catItem.Id,
                                                  Titulo = catItem.Titulo,
                                                  Descripcion = catItem.Descripcion,
                                                  DateTimeItemAdded = catItem.DateTimeItemAdded,
                                                  TipodeMedioId = catItem.TipodeMedioId,
                                                  CategoriaId = categoriaId
                                              }
                                              ).ToListAsync();
            //Esto devolvera todas las partes pequeñas de las categorias, Por ello se tiene que modificar
            //de modo que en la parte de arriba de este codigo se pueda filtrar para que no muestre
            //todas las partes pequeñas de las categorias 
            return View(await _context.CategoriasItem.ToListAsync());
        }

        // GET: Admin/CategoriaItem/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaItem = await _context.CategoriasItem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoriaItem == null)
            {
                return NotFound();
            }

            return View(categoriaItem);
        }

        // GET: Admin/CategoriaItem/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/CategoriaItem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Descripcion,DateTimeItemAdded,CategoriaId,TipodeMedioId")] CategoriaItem categoriaItem)
        {
            //Se valida que errores pueden salir a la hora de crear una categoriaItem
            if (!ModelState.IsValid)
            {
                // Log de errores de validación
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine($"Validation error: {error.ErrorMessage}");
                }
            }
            if (ModelState.IsValid)
            {
                _context.Add(categoriaItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaItem);
        }

        // GET: Admin/CategoriaItem/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaItem = await _context.CategoriasItem.FindAsync(id);
            if (categoriaItem == null)
            {
                return NotFound();
            }
            return View(categoriaItem);
        }

        // POST: Admin/CategoriaItem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Descripcion,DateTimeItemAdded,CategoriaId,TipodeMedioId")] CategoriaItem categoriaItem)
        {
            if (id != categoriaItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoriaItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaItemExists(categoriaItem.Id))
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
            return View(categoriaItem);
        }

        // GET: Admin/CategoriaItem/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaItem = await _context.CategoriasItem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoriaItem == null)
            {
                return NotFound();
            }

            return View(categoriaItem);
        }

        // POST: Admin/CategoriaItem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoriaItem = await _context.CategoriasItem.FindAsync(id);
            if (categoriaItem != null)
            {
                _context.CategoriasItem.Remove(categoriaItem);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaItemExists(int id)
        {
            return _context.CategoriasItem.Any(e => e.Id == id);
        }
    }
}
