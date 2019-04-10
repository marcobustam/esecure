using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bbs.Models.Params
{
    public class Site
    {
        public int SiteID { get; set; }
        public string SiteName { get; set; }
        public IList<WorkSite> WorkSiteList { get; set; }
    }
}
