using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class CrsReslt
    {
        public int id { get; set; }

        public string degree { get; set; }


        public Course course { get; set; }
        [ForeignKey("course")]
        public int Crs_id { get; set; }

        public Trainee Trainee { get; set; }
        [ForeignKey("Trainee")]
        public int trainee_id { get; set; }



    }
}
