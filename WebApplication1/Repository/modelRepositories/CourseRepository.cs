using WebApplication1.Models;
using WebApplication1.Repository.ImodelRepository;

namespace WebApplication1.Repository.modelRepositories
{
    public class CourseRepository : ICourseRepository 
    {
        MVCProjectContext context;


        public CourseRepository(MVCProjectContext context)
        {
            this.context = context;

        }

        public void Add(Course obj)
        {//understand tha the obj is of Course
            context.Add(obj);
        }

        public void Delete(int id)
        {
            //select course 
            Course course = GetById(id);

            context.Remove(course);
        }

        public List<Course> GetAll()
        {
            return context.Course.ToList();
        }

        public Course GetById(int id)
        {
            return context.Course.FirstOrDefault(x => x.Id == id);
        }

        public int Save()
        {
            return context.SaveChanges();
        }

        public void Update(Course obj)
        {
            context.Update(obj);
        }

        //crud operations















    }
}
