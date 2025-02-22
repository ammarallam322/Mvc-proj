using WebApplication1.Models;
using WebApplication1.Repository.ImodelRepository;

namespace WebApplication1.Repository.modelRepositories
{
    public class instructorRepository : RepositoryGeneric<Instructor>, IinstructorRepository
    {
        //obj from contex

        MVCProjectContext contest;

        public instructorRepository(MVCProjectContext contest)
        {
            this.contest = contest;
        }

      

        public override List<Instructor> GetAll()
        {
           return contest.Instructors.ToList();
        }

        public override Instructor GetById(int id)
        {
            return contest.Instructors.FirstOrDefault(i => i.Id == id);
        }

        public void Add(Instructor obj)
        {
            contest.Add(obj);
        }
        public void Delete(int id)
        {
           //select then delete im one step

            contest.Remove(GetById(id));
        }


        public int Save()
        {
          return  contest.SaveChanges();
        }

        public void Update(Instructor obj)
        {
            contest.Update(obj);
        }
    }
}
