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
    public class StatisticsModel : PageModel
    {
        private readonly CreateStatistics createStatistics;

        public StatisticsModel(IRepository repository)
        {
            createStatistics = new CreateStatistics(repository);
        }

        [BindProperty]
        public List<StudentStatistics> Statistics { get; set; }

        public void OnGet()
        {
            Statistics = new List<StudentStatistics>();

            Statistics = createStatistics.ListAllStatistics();
        }
    }
}
