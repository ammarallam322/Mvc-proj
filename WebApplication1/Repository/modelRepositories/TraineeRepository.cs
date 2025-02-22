using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication1.Models;
using WebApplication1.Repository.ImodelRepository;

namespace WebApplication1.Repository.modelRepositories
{
    public class TraineeRepository : RepositoryGeneric<Trainee>, ITraineeRepository
    {//ref from context
        MVCProjectContext context;

        public TraineeRepository(MVCProjectContext context)
        {
            this.context = context;
        }



        public override List<Trainee> GetAll()
        {
            //var query = projectContext.courseResults.
            //    Where(n => n.Crs_id == crsId).
            //    Include(n => n.course).
            //    Include(n => n.Trainee).Select(n => new
            //    {
            //        courseId = n.Crs_id,
            //        traineeId = n.trainee_id,
            //        traineeName = n.Trainee.Name,
            //        courseName = n.course.Name,
            //        grade = n.degree,
            //        mindegree = n.course.minDegree




            //    }).ToList();
            var query=context.Trainees.Select(n=>n) .ToList();

            return query;
        }

        public override Trainee GetById(int id)
        {
            return context.Trainees.FirstOrDefault(t => t.Id == id);
        }

        public void Add(Trainee obj)
        {
            context.Add(obj);
        }

        public void Delete(int id)
        {
            context.Remove(GetById(id));    
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
