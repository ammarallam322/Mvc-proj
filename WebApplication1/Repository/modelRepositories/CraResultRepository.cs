using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Repository.ImodelRepository;

namespace WebApplication1.Repository.modelRepositories
{
    public class CraResultRepository : ICraResultRepository
    {

        MVCProjectContext projectContext;

        public CraResultRepository(MVCProjectContext projectContext)
        {
            this.projectContext = projectContext;
        }

        public object getByCrsidAndTrainid(int courseid, int traineeid)
        {
            var obj1 = projectContext.courseResults.
                Where(n => n.Crs_id == courseid && n.trainee_id == traineeid).
                Include(n => n.Trainee).
                Include(n => n.course).Select(n => new
                {

                    traineeId = n.trainee_id,
                    traineeName = n.Trainee.Name,
                    courseName = n.course.Name,
                    grade = n.degree,
                    mindegree = n.course.minDegree
                }).FirstOrDefault();

            dto obj2 = new dto();


            obj2.traineeId = obj1.traineeId;
            obj2.mindegree = obj1.mindegree;

            obj2.traineeName = obj1.traineeName;

            obj2.courseName = obj1.courseName;
            obj2.grade = obj1.grade;

            return obj2;
        }

    }


    //class DTO data transferobject  for mapping

    public class dto
    {


        public int traineeId { get; set; }

        public int courseId { get; set; }

        public string traineeName { get; set; }
        public string courseName { get; set; }

        public string grade { get; set; }

        public int mindegree { get; set; }




    }
}
