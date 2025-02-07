using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Course
    {



        public int Id { get; set; }
        [courseUniqueName]
        [MinLength(3,ErrorMessage=" min length = 3 chars")]
        public string Name { get; set; }

        [Range(minimum: 50, maximum:100, ErrorMessage = "degree is between 50 and 100")]
        public int  degree { get; set; }

        [Remote("CheckMinDegree", "Course", ErrorMessage ="mid degree must be less than degree",AdditionalFields = "degree")]
        public int  minDegree { get; set; }
        [Remote("checkHours", "Course", ErrorMessage = "hours must be divided by 3")]

        public int  hours { get; set; }


        public List<CrsReslt> result { get; set; }

        public List<Instructor> instructors { get; set; }

        public Department Department { get; set; }
        [ForeignKey(nameof(Department))]
        public int deptId { get; set; }
    }
}
