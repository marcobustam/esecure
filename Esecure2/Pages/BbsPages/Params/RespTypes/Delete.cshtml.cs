﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.EntityFrameworkCore;
//using bbs.Models;
//using bbs.Models.Params;
//using Esecure2.Data;

//namespace Bbs.Pages.Params.RespTypes
//{
//    public class DeleteModel : PageModel
//    {
//        private readonly BbsContext _context;

//        public DeleteModel(BbsContext context)
//        {
//            _context = context;
//        }

//        [BindProperty]
//        public RespType RespType { get; set; }

//        public async Task<IActionResult> OnGetAsync(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            RespType = await _context.RespType.FirstOrDefaultAsync(m => m.RespTypeID == id);

//            if (RespType == null)
//            {
//                return NotFound();
//            }
//            return Page();
//        }

//        public async Task<IActionResult> OnPostAsync(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            RespType = await _context.RespType.FindAsync(id);

//            if (RespType != null)
//            {
//                _context.RespType.Remove(RespType);
//                await _context.SaveChangesAsync();
//            }

//            return RedirectToPage("./Index");
//        }
//    }
//}
