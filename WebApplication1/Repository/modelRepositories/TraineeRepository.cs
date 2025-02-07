using WebApplication1.Models;
using WebApplication1.Repository.ImodelRepository;

namespace WebApplication1.Repository.modelRepositories
{
    public class TraineeRepository : ITraineeRepository
    {//ref from context
        MVCProjectContext context;

        public TraineeRepository(MVCProjectContext context)
        {
            this.context = context;
        }

        public void Add(Trainee obj)
        {
            context.Add(obj);
        }

        public void Delete(int id)
        {
            context.Remove(GetById(id));    
        }

        public List<Trainee> GetAll()
        {
          return  context.Trainees.ToList();
        }

        public Trainee GetById(int id)
        {
           return context.Trainees.FirstOrDefault(t=>t.Id==id);
        }

        public int Save()
        {
           return context.SaveChanges();
        }

        public void Update(Trainee obj)
        {
            context.Update(obj);
        }
    }
}
