using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class InstructotwithlistDepartmentWithlistCourseViewModel
    {
        //instructor properties

        public int Id { get; set; }

        public string Name { get; set; }
        public string imageUrl { get; set; }
        public string address { get; set; }

        public int salary { get; set; }


        public List<Course> Courses { get; set; }

        public int crs_id { get; set; }

        public List<Department> Departments { get; set; }
      
        public int deptId { get; set; }










    }
}
