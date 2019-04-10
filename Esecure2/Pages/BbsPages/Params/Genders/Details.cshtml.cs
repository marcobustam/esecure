﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bbs.Models.Params;
using Esecure2.Data;
namespace Bbs.Pages.Params.Genders
{
    public class DetailsModel : PageModel
    {
        private readonly BbsContext _context;

        public DetailsModel(BbsContext context)
        {
            _context = context;
        }

        public Gender Gender { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gender = await _context.Gender.FirstOrDefaultAsync(m => m.GenderId == id);

            if (Gender == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
