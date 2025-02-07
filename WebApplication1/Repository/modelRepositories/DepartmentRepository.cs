using WebApplication1.Models;
using WebApplication1.Repository.ImodelRepository;

namespace WebApplication1.Repository.modelRepositories
{
    public class DepartmentRepository : IDepartmentRepository
    {

        MVCProjectContext context;


        public DepartmentRepository(MVCProjectContext context)
        {
            this.context = context;
        }
        public List<Department> GetAll()
        {
            return context.Departments.ToList();
        }

        public Department GetById(int id)
        {
          return  context.Departments.FirstOrDefault(d => d.Id == id);
        }


        public void Add(Department obj)
        {
           context.Add(obj);
        }

        public void Delete(int id)
        {
            //select then delete in one step
            context.Remove(GetById(id));
           
        }


        public void Update(Department obj)
        {
            context.Update(obj);
        }

        public int Save()
        {
           return context.SaveChanges();
        }


    }
}
