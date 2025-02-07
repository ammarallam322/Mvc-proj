namespace WebApplication1.Models
{
    public class Department
    {


        public int Id { get; set; }

        public string Name { get; set; }

        public string maneger { get; set; }



        //nav

        public List<Trainee> Trainees { get; set; }
        public List<Instructor> instructors { get; set; }
        public List<Course> courses { get; set; }

    }
}
