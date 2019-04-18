//using Esecure2.Data;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace EsecureModel.Bbs.Bussiness
//{
//    public class Indicators
//    {
//        private readonly BbsContext _context;
//        public Indicators(BbsContext context)
//        {
//            _context = context;
//        }

//        public JsonResult GetNumbers(string data)
//        {

//            var PersonCount = _context.Person.ToList().Count;
//            var OkObsCount = _context.Inspection.Where(ins => ins.IsSafeAction == true).ToList().Count;
//            var NokObsCount = _context.Inspection.Where(ins => ins.IsSafeAction == false).ToList().Count;
//            var TotObsCount = _context.Inspection.ToList().Count;



//            /***
//            var results = from p in persons
//              group p.car by p.PersonId into g
//              select new { PersonId = g.Key, Cars = g.ToList() };
//Or as a non-query expression:

//var results = persons.GroupBy(
//    p => p.PersonId, 
//    p => p.car,
//    (key, g) => new { PersonId = key, Cars = g.ToList() });


//    */
//            var sql = from d in _context.Person
//                      group d.PersonID by d.GenderID into p
//                      select new { Sexo = p.Key, Q = p.ToList().Count };

//            IList<object> listaEstat;
//            listaEstat = new List<object>{ PersonCount, OkObsCount, NokObsCount, TotObsCount, sql};
//            return new JsonResult(listaEstat);

//        }

//    }
//}
