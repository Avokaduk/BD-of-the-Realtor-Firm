﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_of_the_Realtor_Firm.Data;
using BD_of_the_Realtor_Firm.Models;

namespace BD_of_the_Realtor_Firm.Pages.Positions_
{
    public class IndexModel : PageModel
    {
        private readonly BD_of_the_Realtor_Firm.Data.BD_of_the_Realtor_FirmContext _context;

        public IndexModel(BD_of_the_Realtor_Firm.Data.BD_of_the_Realtor_FirmContext context)
        {
            _context = context;
        }

        public IList<Positions> Positions { get;set; }

        public async Task OnGetAsync()
        {
            Positions = await _context.Positions.ToListAsync();
        }
    }
}
