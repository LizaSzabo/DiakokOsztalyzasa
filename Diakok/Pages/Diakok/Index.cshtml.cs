using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Diakok.DAL;
using Diakok.Model;
using Diakok.BLL;

namespace Diakok.Pages.Diakok
{
    public class IndexModel : PageModel
    {
        private readonly ListStudents listDiakok;

        public IndexModel(IRepository repository)
        {
            listDiakok = new ListStudents(repository);
        }

        public IList<Student> Student { get;set; }

        public void OnGet()
        {
            Student = listDiakok.ListAllStudents();
        }
    }
}
