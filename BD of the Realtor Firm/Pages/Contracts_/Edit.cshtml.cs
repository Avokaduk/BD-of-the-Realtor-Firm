﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BD_of_the_Realtor_Firm.Data;
using BD_of_the_Realtor_Firm.Models;

namespace BD_of_the_Realtor_Firm.Pages.Contracts_
{
    public class EditModel : PageModel
    {
        private readonly BD_of_the_Realtor_Firm.Data.BD_of_the_Realtor_FirmContext _context;

        public EditModel(BD_of_the_Realtor_Firm.Data.BD_of_the_Realtor_FirmContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Contracts Contracts { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contracts = await _context.Contracts.FirstOrDefaultAsync(m => m.ID == id);

            if (Contracts == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Contracts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContractsExists(Contracts.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ContractsExists(long id)
        {
            return _context.Contracts.Any(e => e.ID == id);
        }
    }
}
