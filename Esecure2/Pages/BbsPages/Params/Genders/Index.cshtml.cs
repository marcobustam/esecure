﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bbs.Models;
using bbs.Models.Params;
using Esecure2.Data;

namespace Bbs.Pages.Params.Genders
{
    public class IndexModel : PageModel
    {
        private readonly BbsContext _context;

        public IndexModel(BbsContext context)
        {
            _context = context;
        }

        public IList<Gender> Gender { get;set; }

        public async Task OnGetAsync()
        {
            Gender = await _context.Gender.ToListAsync();
        }
    }
}