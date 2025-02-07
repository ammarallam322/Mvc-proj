using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication1.Models;
using WebApplication1.Repository.ImodelRepository;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class CourseController : Controller
    {
        //MVCProjectContext projectContext=new MVCProjectContext();

        ICourseRepository courseRepository;
        IDepartmentRepository departmentRepository;

        public CourseController(ICourseRepository courseRepository        ,  IDepartmentRepository departmentRepository        )
        {
            this.departmentRepository = departmentRepository;


            this.courseRepository = courseRepository;
        }






        public IActionResult Result(int crsId)
        {  //  Course/Result/1

            //list of my model 

            List<TraineeWithCourseResultViewModel> modellist =new List<TraineeWithCourseResultViewModel>();

            MVCProjectContext projectContext=new MVCProjectContext();
            //take course id and return all student


            var query = projectContext.courseResults.
                Where(n => n.Crs_id == crsId).
                Include(n => n.course).
                Include(n => n.Trainee).Select(n=>new
                {
                    courseId= n.Crs_id,
                    traineeId = n.trainee_id,
                    traineeName = n.Trainee.Name,
                    courseName = n.course.Name,
                    grade = n.degree,
                    mindegree = n.course.minDegree

                


                }).ToList();

            // foreach of collection and mapping on list of my model

            foreach (var item in query)
            {
                var model = new TraineeWithCourseResultViewModel();
                  model.traineeId = item.traineeId;
                model.traineeName = item.traineeName;
                model.courseId=item.courseId;
                model.coursNName = item.courseName;
                model.grade = Convert.ToInt32(item.grade);

                if (model.grade < item.mindegree) model.color = "red";





                modellist.Add(model);


            }



            return View("Result", modellist);
        }

        // all courses

        //    Course/Index
        public IActionResult All()
        {  //  Course/All

            //list of my model 

            List<TraineeWithCourseResultViewModel> modellist = new List<TraineeWithCourseResultViewModel>();

            MVCProjectContext projectContext=new MVCProjectContext();
            //take course id and return all student


            var query = projectContext.courseResults.
               
                Include(n => n.course).
                Include(n => n.Trainee).Select(n => new
                {
                    courseId = n.Crs_id,
                    traineeId = n.trainee_id,
                    traineeName = n.Trainee.Name,
                    courseName = n.course.Name,
                    grade = n.degree,
                    mindegree = n.course.minDegree




                }).ToList();

            // foreach of collection and mapping on list of my model

            foreach (var item in query)
            {
                var model = new TraineeWithCourseResultViewModel();
                model.traineeId = item.traineeId;
                model.traineeName = item.traineeName;
                model.courseId = item.courseId;
                model.coursNName = item.courseName;
                model.grade = Convert.ToInt32(item.grade);

                if (model.grade < item.mindegree) model.color = "red";





                modellist.Add(model);


            }



            return View("All", modellist);
        }


        public IActionResult Index()
        {
            //obj from course

            List<Course> courses = new List<Course>();

            //lists of 
            courses= courseRepository.GetAll();

            return View("Index", courses);


        }
        // action new 

        public IActionResult New() {
        // getting department lists

            CourseWithdepartmentsViewModel course = new CourseWithdepartmentsViewModel();
            List<Department> deptList = departmentRepository.GetAll();
          
            course.departments = deptList;
         



        return View("New", course);
        }
        //Course/All

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveNew(CourseWithdepartmentsViewModel crsfromRequest)
        {
            try
            {


                if (ModelState.IsValid == true)
                {

                    Course course = new Course();

                    course.Name = crsfromRequest.Name;
                    course.degree = crsfromRequest.degree;
                    course.minDegree = crsfromRequest.minDegree;
                    course.hours = crsfromRequest.hours;
                    course.deptId = crsfromRequest.deptId;

                    //adding in data base
                    courseRepository.Add(course);
                    courseRepository.Save();

                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex) { ModelState.AddModelError("deptId", "you must dep"); }

            //refilling lists 
            List<Department> deptList = departmentRepository.GetAll();
            crsfromRequest.departments = deptList;

            return View("New", crsfromRequest);


        }

            #region  
            ////validation
            //if (crsfromRequest.Name!= null&&crsfromRequest.degree!=null&&crsfromRequest.minDegree!=null&&crsfromRequest.hours!=null&&crsfromRequest.deptId!=null) 

            //    {
            //    //creating obj from course and mapping info on it 


            //    Course course = new Course();
            //    course.Name = crsfromRequest.Name;
            //    course.degree = crsfromRequest.degree;
            //    course.minDegree = crsfromRequest.minDegree;
            //    course.hours = crsfromRequest.hours;
            //    course.deptId = crsfromRequest.deptId;

            //    //adding in data base
            //    projectContext.Add(course);
            //    projectContext.SaveChanges();

            //    return RedirectToAction("Index");



            //    }


            ////refilling lists 
            //List<Department> deptList = projectContext.Departments.ToList();
            //crsfromRequest.departments = deptList;

            //return View("New",crsfromRequest);

            #endregion

        //search controller

        public IActionResult Search(string term)
        {

            ////obj fom cours

            //List<Course> courses = new List<Course>();
            ////getting all courses starts with term
            //if (term != "" &&term!=null)
            //{
            //    courses = projectContext.Course
            //       .Where(n => n.Name.StartsWith(term))
            //       .ToList();
            //}
            //courses = projectContext.Course.ToList();

            //return View("Index", courses);


            //----------------------------

            List<Course> courses;


            // 
            if (!string.IsNullOrEmpty(term))
            {
                courses =  courseRepository.GetAll()

                    .Where(n => n.Name.StartsWith(term))
                    .ToList();  
            }
            else
            {
                courses = courseRepository.GetAll();
            }

            return View("Index", courses);  


        }


        // action for  mindegree //parameters and prperties  must be same?
        public IActionResult CheckMinDegree(int minDegree, int degree)
        {

            if (minDegree > 0 && minDegree < degree) { return Json(true); }
            else { return Json(false); }

            //return (minDegree < degree) ?  Json (true):Json(false);

        }

        // action for  hours //parameters and prperties  must be same? 
        public IActionResult checkHours(int  hours)
        {

            if (hours%3==0) { return Json(true); }
            else { return Json(false); }




            //return (hours%3==0)? Json(true):Json(false);
        }











    }
}
