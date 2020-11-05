using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_of_the_Realtor_Firm.Data;
using BD_of_the_Realtor_Firm.Models;

namespace BD_of_the_Realtor_Firm.Pages.ZF.filters
{
    public class BuyModel : PageModel
    {
        private readonly BD_of_the_Realtor_Firm.Data.BD_of_the_Realtor_FirmContext _context;

        public BuyModel(BD_of_the_Realtor_Firm.Data.BD_of_the_Realtor_FirmContext context)
        {
            _context = context;
        }

        public IList<Buyers> Buyers { get; set; }
        public Apartments Apartments { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Apartments = await _context.Apartments.FirstOrDefaultAsync(m => m.ID == id);

            if (Apartments == null)
            {
                return NotFound();
            }
            Buyers = await _context.Buyers.Where(m => m.TypeID == Apartments.ID).ToListAsync();
            return Page();
        }
    }
}
