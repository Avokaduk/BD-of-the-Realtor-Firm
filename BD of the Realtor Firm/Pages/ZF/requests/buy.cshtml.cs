using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_of_the_Realtor_Firm.Data;
using BD_of_the_Realtor_Firm.Models;

namespace BD_of_the_Realtor_Firm.Pages.ZF.requests
{
    public class buyModel : PageModel
    {
        private readonly BD_of_the_Realtor_Firm.Data.BD_of_the_Realtor_FirmContext _context;

        public buyModel(BD_of_the_Realtor_Firm.Data.BD_of_the_Realtor_FirmContext context)
        {
            _context = context;
        }

        public IList<Buyers> Buyers { get; set; }
        public IList<Apartments> Apartments { get; set; }

        public async Task OnGetAsync()
        {
            Buyers = await _context.Buyers.ToListAsync();
            Apartments = await _context.Apartments.ToListAsync();
        }
    }
}
