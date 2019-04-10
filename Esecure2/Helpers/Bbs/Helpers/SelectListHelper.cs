using Esecure2.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bbs.Models.Helpers
{
    public class SelectListHelper
    {

        public static SelectList _personasSL { private set; get; }

        public static SelectList GetPersonasDropDownList(BbsContext context, object selectedPersona = null)
        {
            var personasQuery = from d in context.Person
                                orderby d.Names // Sort by name.
                                select d;

            _personasSL = new SelectList(personasQuery.AsNoTracking(),
                        "PersonID", "FirstName", selectedPersona);

            return _personasSL;
        }

    }
}
