using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class CourseWithdepartmentsViewModel
    {


        public int Id { get; set; }
        [courseUniqueName]
        [MinLength(3, ErrorMessage = " min length = 3 chars")]
        public string Name { get; set; }


        [Range(minimum: 50, maximum: 100, ErrorMessage = "degree is between 50 and 100")]

        public int degree { get; set; }
        [Remote("CheckMinDegree", "Course", ErrorMessage = "mid degree must be less than degree", AdditionalFields = "degree")]

        public int minDegree { get; set; }
        [Remote("checkHours", "Course",ErrorMessage ="hours must be divided by 3")]
        public int hours { get; set; }

        public List< Department>? departments { get; set; }

        public int deptId { get; set; }











    }
}
