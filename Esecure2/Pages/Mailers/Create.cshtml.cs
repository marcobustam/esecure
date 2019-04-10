using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Esecure2.Data;
using EsecureModel.Mailer;
using EsecureWebApp.Mailers;
using Microsoft.Extensions.Configuration;
using EsecureModel.Usuario;
using Microsoft.AspNetCore.Identity;

namespace EsecureWebApp.Pages.Mailers
{
    public class CreateModel : BaseCodeModel
    {
        private readonly ApplicationDbContext _context;
        // public static IConfiguration _configuration { get; private set; }

        public CreateModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MailSender MailSender { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            MailSender.Timestamp = DateTime.Now;
            _context.MailSender.Add(MailSender);
            await _context.SaveChangesAsync();
            var ms = new EmailHelper(_context);
            var mails = ms.SendEmail(MailSender.MailSenderFrom, MailSender.MailSenderTo, MailSender.MailSenderSubject, MailSender.MailSenderMessage);
            return RedirectToPage("./Index");
        }
    }
}