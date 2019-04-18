//using System;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using Esecure2.Data;
//using EsecureModel.Bbs.Bussiness;

//namespace Bbs.Pages.Bl
//{
//    public class CreateModel : PageModel
//    {
//        private readonly BbsContext _context;

//        public CreateModel(BbsContext context)
//        {
//            _context = context;
//        }
//        public SelectList SlPersons { get; private set; }
//        public SelectList SlPersonObservers { get; private set; }
//        public SelectList SlPersonObserved { get; private set; }
//        public SelectList SlPersonDirector { get; private set; }
//        public SelectList SlCategories { get; private set; }
//        public SelectList SlItems { get; private set; }
//        public SelectList SlWorkSites { get; private set; }
//        public SelectList SlSites { get; private set; }
//        public SelectList SlDivisions { get; private set; }
//        public SelectList getSlPersonas()
//        {
//            var personasQuery = from d in _context.Person
//                                orderby d.Names // Sort by name.
//                                select d;
//            return new SelectList(personasQuery.AsNoTracking(),
//                        "PersonID", "Names", null);
//        }

//        public SelectList getSlDirectores()
//        {
//            var DirectorQuwery = from d in _context.Person
//                                 where d.IsDirector == true
//                                 orderby d.Names // Sort by name.
//                                 select d;
//            return new SelectList(DirectorQuwery.AsNoTracking(),
//                        "PersonID", "Names", null);
//        }
//        private SelectList getSlObservadores()
//        {
//            var QrPersonObservers = from d in _context.Person
//                                    where d.IsObserver == true
//                                    orderby d.Names // Sort by name.
//                                    select d;
//            return new SelectList(QrPersonObservers.AsNoTracking(),
//                        "PersonID", "Names", null);
//        }
//        private SelectList getSlOvservados()
//        {
//            var QrPersonObserved = from d in _context.Person
//                                   where d.IsObserved == true
//                                   orderby d.Names // Sort by name.
//                                   select d;
//            return new SelectList(QrPersonObserved.AsNoTracking(),
//                        "PersonID", "Names", null);
//        }
//        private SelectList getSlCategorias()
//        {
//            var QrCategories = from d in _context.ObsCategory
//                               orderby d.ObsCategoryID // Sort by name.
//                               select d;
//            return new SelectList(QrCategories.AsNoTracking(),
//                        "ObsCategoryID", "ObsCategoryDescription", null);
//        }
//        private SelectList getSlItems()
//        {
//            var QrItems = from d in _context.ObsItem
//                          orderby d.ObsItemDescription // Sort by name.
//                          select d;
//            return new SelectList(QrItems.AsNoTracking(),
//                        "ObsItemID", "ObsItemDescription", null);
//        }
//        private SelectList getSlSites()
//        {
//            var QrSites = from d in _context.Site
//                          orderby d.SiteName // Sort by name.
//                          select d;
//            return new SelectList(QrSites.AsNoTracking(),
//                        "SiteID", "SiteName", null);
//        }
//        private SelectList getSlWorkSites()
//        {
//            var QrWorkSites = from d in _context.WorkSite
//                              orderby d.WorkSiteName // Sort by name.
//                              select d;
//            return new SelectList(QrWorkSites.AsNoTracking(),
//                        "WorkSiteID", "WorkSiteName", null);
//        }
//        private SelectList getSlDivisiones()
//        {
//            var QrDivisions = from d in _context.Division
//                              orderby d.DivisionName // Sort by name.
//                              select d;
//            return new SelectList(QrDivisions.AsNoTracking(),
//                        "DivisionID", "DivisionName", null);
//        }

//        private void GetSls()
//        {
//            /****************************************************************/
//            SlPersons = getSlPersonas();
//            /****************************************************************/
//            SlPersonDirector = getSlDirectores();
//            /****************************************************************/
//            SlPersonObservers = getSlObservadores();
//            /****************************************************************/
//            SlPersonObserved = getSlOvservados();
//            /****************************************************************/
//            SlCategories = getSlCategorias();
//            /****************************************************************/
//            SlItems = getSlItems();
//            /****************************************************************/
//            SlSites = getSlSites();
//            /****************************************************************/
//            SlWorkSites = getSlWorkSites();
//            /****************************************************************/
//            SlDivisions = getSlDivisiones();
//            /****************************************************************/
//        }
//        public IActionResult OnGet()
//        {
//            try
//            {
//                GetSls();
//                return Page();
//            }
//            catch (Exception e)
//            {
//                return RedirectToPage("/Error", new { ErrorMsg = e.Message });
//            }
//            finally
//            {
//                RedirectToPage("/Bl/Create");
//            }
//        }



//        [BindProperty]
//        public Inspection Inspection { get; set; }

//        public async Task<IActionResult> OnPostAsync()
//        {
//            try
//            {
//                if (!ModelState.IsValid)
//                {
//                    GetSls();
//                    return Page();
//                }
//                Inspection.Timestamp = DateTime.Now;
//                _context.Inspection.Add(Inspection);
//                await _context.SaveChangesAsync();
//                return RedirectToPage("/Indicators");
//            }
//            catch (Exception e)
//            {
//                return RedirectToPage("/Error", new { ErrorMsg = e.Message });
//            }
//            finally
//            {
//                RedirectToPage("/Indicators");
//            }
//        }
//    }
//}