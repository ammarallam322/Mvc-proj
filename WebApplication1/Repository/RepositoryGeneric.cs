using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public abstract class RepositoryGeneric<t> : IRepositoryGeneric<t>  where t : class // t is a reference dattype
    {
        //ref from my context --------

        MVCProjectContext context;




        public void Add(t obj)
        {
          context.Add(obj)  ;
        }

        public void Delete(int id)
        {
            context.Remove(GetById(id)) ;

        }

        public  abstract List<t> GetAll();//must extend this method in child class

        public abstract t GetById(int id);//must extend this method in child class
       


        public void Update(t obj)
        {
            context.Update(obj) ;
        }

        public int Save()
        {
            return context.SaveChanges();
        }
      

    
    }
}
