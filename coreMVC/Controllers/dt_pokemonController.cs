using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using coreMVC.Models;

namespace coreMVC.Controllers
{
    public class dt_pokemonController : Controller
    {
        private readonly PokemonGoContext _context;

        public dt_pokemonController(PokemonGoContext context)
        {
            _context = context;
        }

        // GET: dt_pokemon
        public async Task<IActionResult> Index()
        {
            return View(await _context.dt_pokemon.ToListAsync());
        }

        // GET: dt_pokemon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dt_pokemon = await _context.dt_pokemon
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dt_pokemon == null)
            {
                return NotFound();
            }

            return View(dt_pokemon);
        }

        // GET: dt_pokemon/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: dt_pokemon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,PokemonName,PokemonAttribute,PokemonAtk,PokemonDef,PokemonVit,Del,PokemonLevel,PokemonItem")] dt_pokemon dt_pokemon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dt_pokemon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dt_pokemon);
        }

        // GET: dt_pokemon/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dt_pokemon = await _context.dt_pokemon.FindAsync(id);
            if (dt_pokemon == null)
            {
                return NotFound();
            }
            return View(dt_pokemon);
        }

        // POST: dt_pokemon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PokemonName,PokemonAttribute,PokemonAtk,PokemonDef,PokemonVit,Del,PokemonLevel,PokemonItem")] dt_pokemon dt_pokemon)
        {
            if (id != dt_pokemon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dt_pokemon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!dt_pokemonExists(dt_pokemon.Id))
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
            return View(dt_pokemon);
        }

        // GET: dt_pokemon/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dt_pokemon = await _context.dt_pokemon
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dt_pokemon == null)
            {
                return NotFound();
            }

            return View(dt_pokemon);
        }

        // POST: dt_pokemon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dt_pokemon = await _context.dt_pokemon.FindAsync(id);
            _context.dt_pokemon.Remove(dt_pokemon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool dt_pokemonExists(int id)
        {
            return _context.dt_pokemon.Any(e => e.Id == id);
        }
    }
}
