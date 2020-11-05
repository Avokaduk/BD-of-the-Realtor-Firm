using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BD_of_the_Realtor_Firm.Pages.ZF
{
    public class IndexModel : PageModel
    {
        private readonly BD_of_the_Realtor_Firm.Data.BD_of_the_Realtor_FirmContext _context;

        public IndexModel(BD_of_the_Realtor_Firm.Data.BD_of_the_Realtor_FirmContext context)
        {
            _context = context;
        }
        public List<SelectListItem> Position { get; set; }
        public List<SelectListItem> Sell { get; set; }
        public List<SelectListItem> Buy { get; set; }
        public List<SelectListItem> Contrac { get; set; }

        public IActionResult OnGet()
        {
            Position = _context.Positions.Select(p =>
                new SelectListItem
                {
                    Value = p.ID.ToString(),
                    Text = p.Position_name
                }).ToList();

            Sell = _context.Sellers.Select(p =>
               new SelectListItem
               {
                   Value = p.TypeID.ToString(),
                   Text = p.Full_name
               }).ToList();

            Buy = _context.Buyers.Select(p =>
               new SelectListItem
               {
                   Value = p.TypeID.ToString(),
                   Text = p.Full_name
               }).ToList();

            Contrac = _context.Contracts.Select(p =>
               new SelectListItem
               {
                   Value = p.StaffID.ToString(),
                   Text = p.amount
               }).ToList();

            return Page();
        }

    }
}

