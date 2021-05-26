using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Diakok.DAL;
using Diakok.Model;
using Diakok.BLL;

namespace Diakok.Pages.Diakok
{
    public class EditModel : PageModel
    {
        private readonly CreateMark createMark;

        public EditModel(IRepository repository)
        {
            createMark = new CreateMark(repository);
        }


        [BindProperty]
        public Student Student { get; set; }
        [BindProperty]
        public Mark Mark { get; set; }

        public IActionResult OnGet(long id)
        {

            Student = createMark.FindStudentById(id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            createMark.AddMark(Student.StudentID, Mark.Value);


            return RedirectToPage("./Index");

        }


    }
}
