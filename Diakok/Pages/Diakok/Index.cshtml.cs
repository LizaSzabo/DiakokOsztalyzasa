using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Diakok.DAL;
using Diakok.Model;

namespace Diakok.Pages.Diakok
{
    public class IndexModel : PageModel
    {
        private readonly IRepository repository;

        public IndexModel(IRepository repository)
        {
            this.repository = repository;
        }

        public IList<Diak> Diak { get;set; }
        public IList<Osztalyzat> Osztalyzat{ get; set; }

        public void OnGetAsync()
        {
            Diak = repository.ListStudents();
            Diak = Diak.OrderBy(o => o.Nev).ToList();
            Osztalyzat = repository.ListOsztalyzatok();
            if(Osztalyzat.Count > 0)
                foreach(var oszt in Osztalyzat)
                     System.Diagnostics.Debug.WriteLine(oszt.Ertek);
        }
    }
}
