using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bbs.Models.Params
{
    public class Person
    {
        public int PersonID { get; set; }
        public string RutChile { get; set; }
        public string Names { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }
        public int GenderID { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsObserved { get; set; }
        public bool IsObserver { get; set; }
        public bool IsDirector { get; set; }
        public int SiteId { get; set; }

        public string EmailAddr { get; set; }

        public string GetPersonName()
        {
            return Names + LastName1 + LastName2;
        }
        private string FullName;

        public string fullName
        {
            set { FullName = Names + ' ' + LastName1 + ' ' + LastName2; }
            get {
                if(!string.IsNullOrEmpty(FullName))
                {
                    FullName = Names + ' ' + LastName1 + ' ' + LastName2;                    
                }
                return FullName;
            }
            
        }

    }
    


}
