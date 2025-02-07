using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string imageUrl { get; set; }
        public string address { get; set; }

        public int grade { get; set; }

        //nav
        public CrsReslt result { get; set; }

   
        public Department Department { get; set; }
        [ForeignKey(nameof(Department))]
        public int deptId { get; set; }
    }
}
