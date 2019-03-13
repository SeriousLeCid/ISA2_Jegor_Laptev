using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KontosoUniversity.Models;
using KontosoUniversity.Models.SchoolViewModels;  // Add VM

namespace KontosoUniversity.Pages.Instructors
{
    public class IndexModel : PageModel
    {
        private readonly KontosoUniversity.Models.SchoolContext _context;

        public IndexModel(KontosoUniversity.Models.SchoolContext context)
        {
            _context = context;
        }
        public InstructorIndexData Instructor { get; set; }
        public int InstructorID { get; set; }

        public async Task OnGetAsync(int? id)
        {
            Instructor = new InstructorIndexData();
            Instructor.Instructors = await _context.Instructors
                  .Include(i => i.OfficeAssignment)
                  .Include(i => i.CourseAssignments)
                    .ThenInclude(i => i.Course)
                  .AsNoTracking()
                  .OrderBy(i => i.LastName)
                  .ToListAsync();

            if (id != null)
            {
                InstructorID = id.Value;
            }
        }
    }
}