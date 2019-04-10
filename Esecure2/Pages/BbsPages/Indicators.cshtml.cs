using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using bbs.Models.Params;
using Esecure2.Data;
using EsecureModel.Bbs.Bussiness;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Bbs.Pages
{
    public class IndicatorsModel : PageModel
    {
        private readonly BbsContext _context;
        public Indicators Indicatators { get; private set; }

        public JsonResult json { get; private set; }

        public IndicatorsModel(BbsContext context)
        {
            _context = context;
        }
        public IList<int> IconCardStats { get; private set; }
        public IList<int> PorcGral { get; private set; }

        public class Datagrid
        {
            public List<List<int>> DataListas { get; internal set; }
            public string SerieName { get; set; }
            public IList<string> LabelList { get;set; }
            public IList<int> DataList { get;set; }

        }

        public Datagrid  Datagrd { get; set; }
        public Datagrid  Datagrh { get; set; }
        public Datagrid  Datagra { get; set; }
        public IList<Inspection> InspectionsList { get; set; }
        public IList<object> IndicadoresMensuales { get; private set; }
        private async Task IconCardsAsync()
        {
            var agno = 2019;
            IconCardStats = new List<int>() { 91, 22, 37, 43, 20 };
            List<Inspection> localInsp = await _context.Inspection.ToListAsync();

            var mens1 = await _context.Inspection.GroupBy(g => g.InspectionDate.Month).ToListAsync();
            var mens2 = await _context.Inspection.GroupBy(g => g.InspectionDate.Month.ToString()).Select(g => new { g.Key, Count = g.Count() }).ToListAsync();
            //var mens3 = _context.Inspection.GroupBy(g => g.InspectionDate.Month.ToString("MMMM", CultureInfo.CreateSpecificCulture("es"))).Select(g => new { g.Key, Count = g.Count() }).ToList();
            var mens = _context.Inspection.Select(i => new { mes = i.InspectionDate.ToString("MMMM", CultureInfo.CreateSpecificCulture("es")), Accion = i.IsSafeAction });

            /***************************************************/
            Datagrd = new Datagrid();
            Datagrd.SerieName = "Inspecciones mensuales.";

            /******************************************************************/
            Datagrd.DataListas = new List<List<int>>();
            List<int> listSafes = new List<int>();
            List<int> listUnsafes = new List<int>();
            Datagrd.LabelList = new List<string>();
            for (var mon=1;mon<13;mon++)
            {
                Datagrd.LabelList.Add(new DateTime(agno,mon,01).ToString("MMM", CultureInfo.CreateSpecificCulture("es")));
                listSafes.Add(localInsp.Where(y => y.InspectionDate.Year == 2019 && y.IsSafeAction == true && y.InspectionDate.Month==mon).ToList().Count);
                listUnsafes.Add(localInsp.Where(y => y.InspectionDate.Year == 2019 && y.IsSafeAction == false && y.InspectionDate.Month==mon).ToList().Count);
            }

            Datagrd.DataListas.Add(listSafes);
            Datagrd.DataListas.Add(listUnsafes);


            /******************************************************************/
            //Datagrd.LabelList = await _context.Inspection.Where(y => y.InspectionDate.Year == 2019).Select(i => i.InspectionDate.ToString("MMMM", CultureInfo.CreateSpecificCulture("es")) ).Distinct().ToListAsync();
            Datagrd.DataList = await _context.Inspection.GroupBy(g => g.InspectionDate.Month).Select(g => g.Count() ).ToListAsync();

            
            /*
            {
                    _context.Inspection.Where(y => y.InspectionDate.Year == 2019 && y.IsSafeAction == true).GroupBy(g => g.InspectionDate.Month).Select(g => g.Count()).ToList() ,
                    _context.Inspection.Where(y => y.InspectionDate.Year == 2019 && y.IsSafeAction==false).GroupBy(g => g.InspectionDate.Month).Select(g => g.Count() ).ToList() };
                    */
            //Datagrd.DataListas.Add(await _context.Inspection.Where(y => y.InspectionDate.Year == 2019 && y.IsSafeAction==true).GroupBy(g => g.InspectionDate.Month).Select(g => g.Count() ).ToListAsync());
            //Datagrd.DataListas.Add(await _context.Inspection.Where(y => y.InspectionDate.Year == 2019 && y.IsSafeAction==false).GroupBy(g => g.InspectionDate.Month).Select(g => g.Count() ).ToListAsync());
            //Datagrd.DataListas.Add(localInsp.OrderBy(li=>li.InspectionDate).Where(y => y.InspectionDate.Year == 2019 && y.IsSafeAction == true).GroupBy(g => g.InspectionDate.Month).Select(g => g.Count()).ToList());
            //Datagrd.DataListas.Add(localInsp.OrderBy(li=>li.InspectionDate).Where(y => y.InspectionDate.Year == 2019 && y.IsSafeAction == false).GroupBy(g => g.InspectionDate.Month).Select(g => g.Count()).ToList());

            /***************************************************/
            //  Horizontal bar chart
            Datagrh = new Datagrid();

            Datagrh.SerieName = "Resultados por categorías";
            //Datagrh.LabelList = await _context.ObsCategory.OrderBy(or => or.ObsCategoryID).Select(dl => dl.ObsCategoryDescription).ToListAsync();
            Datagrh.DataList = await _context.Inspection.OrderBy(or => or.ObsCategoryID).Where(y => y.InspectionDate.Year == 2019).GroupBy(g => g.ObsCategoryID).Select(g => g.Count()).ToListAsync();
            Datagrh.DataListas = new List<List<int>>();
            // Datagrh.DataListas.Add(_context.Inspection.OrderBy(or => or.ObsCategoryID).Where(y => y.InspectionDate.Year == 2019 && y.IsSafeAction == true).GroupBy(g => g.ObsCategoryID).Select(g => g.Count()).ToList());
            // Datagrh.DataListas.Add(_context.Inspection.OrderBy(or => or.ObsCategoryID).Where(y => y.InspectionDate.Year == 2019 && y.IsSafeAction == false).GroupBy(g => g.ObsCategoryID).Select(g => g.Count()).ToList());

            List<ObsCategory> categories = await _context.ObsCategory.ToListAsync();

            List<int> listaSafes = new List< int > ();
            List<int> listaUnsafes = new List< int > ();
            Datagrh.LabelList = new List<string>();
            foreach (var cate in categories)
            {
                Datagrh.LabelList.Add(cate.ObsCategoryDescription);
                var safes = (from i in localInsp
                             where (i.InspectionDate.Year == agno && i.ObsCategoryID == cate.ObsCategoryID && i.IsSafeAction == true )
                             select new { i.InspectionID }).ToList().Count;
                listaSafes.Add(safes);             
                var unsafes = (from i in localInsp
                             where (i.InspectionDate.Year == agno && i.ObsCategoryID == cate.ObsCategoryID && i.IsSafeAction == false )
                             select new { i.InspectionID }).ToList().Count;
                listaUnsafes.Add(unsafes);                             
                
            }
            Datagrh.DataListas.Add(listaSafes);
            Datagrh.DataListas.Add(listaUnsafes);
            /***************************************************/
            //  Horizontal bar chart x area
            Datagra = new Datagrid();

            Datagra.SerieName = "Resultados por categorías";
            //Datagrh.LabelList = await _context.ObsCategory.OrderBy(or => or.ObsCategoryID).Select(dl => dl.ObsCategoryDescription).ToListAsync();
            Datagra.DataList = await _context.Inspection.OrderBy(or => or.WorkSiteID).Where(y => y.InspectionDate.Year == agno).GroupBy(g => g.WorkSiteID).Select(g => g.Count()).ToListAsync();
            Datagra.DataListas = new List<List<int>>();
            // Datagrh.DataListas.Add(_context.Inspection.OrderBy(or => or.ObsCategoryID).Where(y => y.InspectionDate.Year == 2019 && y.IsSafeAction == true).GroupBy(g => g.ObsCategoryID).Select(g => g.Count()).ToList());
            // Datagrh.DataListas.Add(_context.Inspection.OrderBy(or => or.ObsCategoryID).Where(y => y.InspectionDate.Year == 2019 && y.IsSafeAction == false).GroupBy(g => g.ObsCategoryID).Select(g => g.Count()).ToList());

            List<WorkSite> worksites = await _context.WorkSite.ToListAsync();

            List<int> listaSafea = new List< int > ();
            List<int> listaUnsafea = new List< int > ();
            Datagra.LabelList = new List<string>();
            foreach (var wosi in worksites)
            {
                Datagra.LabelList.Add(wosi.WorkSiteName);
                var safes = (from i in localInsp
                             where (i.InspectionDate.Year == agno && i.WorkSiteID == wosi.WorkSiteID && i.IsSafeAction == true )
                             select new { i.InspectionID }).ToList().Count;
                listaSafea.Add(safes);             
                var unsafes = (from i in localInsp
                             where (i.InspectionDate.Year == agno && i.WorkSiteID == wosi.WorkSiteID && i.IsSafeAction == false )
                             select new { i.InspectionID }).ToList().Count;
                listaUnsafea.Add(unsafes);                             
                
            }
            Datagra.DataListas.Add(listaSafea);
            Datagra.DataListas.Add(listaUnsafea);
            /***************************************************/

            //var listas = (from a in _context.Inspection
            //               join c in _context.ObsCategory on a.ObsCategoryID equals c.ObsCategoryID
            //               where (a.InspectionDate.Year == 2019 && a.IsSafeAction == true)
            //               select new { c.ObsCategoryID, c.ObsCategoryDescription, a.IsSafeAction, a.InspectionID }).ToList();


            //Datagrh.LabelList = listas.OrderBy(or => or.ObsCategoryID).Select(dl => dl.ObsCategoryDescription).ToList();
            //Datagrh.DataListas.Add(listas.OrderBy(or => or.ObsCategoryID).Where(y => y.IsSafeAction == true).GroupBy(g => g.ObsCategoryDescription).Select(g => g.Count()).ToList());
            //Datagrh.DataListas.Add(listas.OrderBy(or => or.ObsCategoryID).Where(y => y.IsSafeAction == false).GroupBy(g => g.ObsCategoryDescription).Select(g => g.Count()).ToList());


            InspectionsList = await _context.Inspection.ToListAsync();

            //_context.ObsCategory.Select

            /***************************************************/
            /* 
             * var results = (from tn in DataContextInstanse.Tablename
               group tn by tn.Date.Month into bGroup
               orderby bGroup.Key
               select new 
               {
                     Month = bGroup.Key,
                     Count = bGroup.Count()
               }).ToList().Select( r => new 
                   { 
                       Month = new DateTime(2012, r.Month, 1 ).ToString("MMM"),
                       Count = r.Count
                   } ).ToList();
            /***************************************************/

            // string fullMonthName = new DateTime(2015, i, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
            /*
             * 
             * var counts = tableName.GroupBy(x => x.ColumnId)
                      .Select(g => new { g.Key, Count = g.Count() });
             */

            // IndicadoresMensuales = 
            PorcGral = new List<int>() { _context.Inspection.Where(ins => ins.IsSafeAction == false).Count(), _context.Inspection.Where(ins => ins.IsSafeAction == true).Count() };
        }

        public async Task OnGetAsync()
        {
            Indicatators = new Indicators(_context);
            await IconCardsAsync();
            json = Indicatators.GetNumbers("");
        }
    }
}