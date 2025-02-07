using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Instructor
    {



        public int Id { get; set; }

        public string Name { get; set; }
        public string imageUrl { get; set; }
        public string address { get; set; }

        public int salary { get; set; }


        //nav
        public Course Course { get; set; }

        [ForeignKey("Course")]
        public int crs_id { get; set; }

        public Department Department { get; set; }
        [ForeignKey(nameof(Department))]
        public int deptId { get; set; }
    }
}
