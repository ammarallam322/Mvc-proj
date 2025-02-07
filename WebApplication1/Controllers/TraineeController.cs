using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Repository.ImodelRepository;
using WebApplication1.Repository.modelRepositories;
using WebApplication1.ViewModel;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class TraineeController : Controller
    {
        //obj from ....context    Trainee/Result?crsId=1&trnId=1

       // MVCProjectContext mnvcontext = new MVCProjectContext();


        ITraineeRepository traineeRepository;
        ICraResultRepository craResultRepository;
        ICourseRepository courseRepository;

        public TraineeController(ITraineeRepository traineeRepository, ICraResultRepository craResultRepository, ICourseRepository courseRepository)
        {
            this.traineeRepository = traineeRepository;
            this.craResultRepository = craResultRepository;
            this.courseRepository = courseRepository;
        }

        public IActionResult Result(int crsId , int trnId)
        {

            //obj from my moedl
            TraineeWithCourseResultViewModel mymodel = new TraineeWithCourseResultViewModel();
            //query to get data from database
            //get trainee by id and get course by id ???????????????
            dto query = (dto)craResultRepository.getByCrsidAndTrainid(crsId, trnId);



            //mapping on my own model


            mymodel.coursNName = query.courseName;
            mymodel.traineeName= query.traineeName;
            mymodel.traineeId=query.traineeId;
            mymodel.grade=(int.Parse(query.grade));

            if (mymodel.grade< query.mindegree) mymodel.color = "red";


            return View("Result", mymodel);
        }
    }
}
