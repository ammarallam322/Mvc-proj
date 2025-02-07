using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository.ImodelRepository;
using WebApplication1.Repository.modelRepositories;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class InstructorController : Controller
    {

        // obh from MVCProjectContext

      //  MVCProjectContext MVCProjectContext = new MVCProjectContext();
     
        IinstructorRepository instructorRepository;

        IDepartmentRepository departmentRepository;
        ICourseRepository courseRepository;

        public InstructorController(IinstructorRepository instructorRepository, IDepartmentRepository departmentRepository, ICourseRepository courseRepository)
        {
            this.instructorRepository = instructorRepository;
            this.departmentRepository = departmentRepository;
            this.courseRepository = courseRepository;
        }


        //injecting in constuctor
        public IActionResult All()
        {
            List<Instructor> instructrListmodel = instructorRepository.GetAll();


            return View("All", instructrListmodel);
        }

        public IActionResult Details(int id)
        {

            Instructor current = instructorRepository.GetById(id);


            return View("Details", current);

        }



        public IActionResult Add()
        {
            var mymodelVm = new InstructotwithlistDepartmentWithlistCourseViewModel();

            //appending lists

            mymodelVm.Departments = departmentRepository.GetAll();

            mymodelVm.Courses = courseRepository.GetAll();

            return View("Add", mymodelVm);
        }

        [HttpPost]
        public IActionResult saveAdd(Instructor insfromRequest)
        {

            //modelstate?
            //validation if null
            if (insfromRequest.Name != null)
            {

                //gettimg gata from inputs 

                instructorRepository.Add(insfromRequest);

                instructorRepository.Save();



                return RedirectToAction("All");

            }

            var mymodelVm = new InstructotwithlistDepartmentWithlistCourseViewModel();

            //appending lists

            mymodelVm.Departments = departmentRepository.GetAll();

            mymodelVm.Courses = courseRepository.GetAll();

            return View("Add", mymodelVm);


        }





        public IActionResult Edit(int id)
        {

            // get current instructor from database

            Instructor insmodel = instructorRepository.GetById(id);

            //getting list from departments

            List<Department> departments =departmentRepository.GetAll();

            //getting list from course

            List<Course> courses = courseRepository.GetAll();



            InstructotwithlistDepartmentWithlistCourseViewModel insmodelVm = new InstructotwithlistDepartmentWithlistCourseViewModel();

            //mapping
            #region
            insmodelVm.Id = insmodel.Id;
            insmodelVm.address = insmodel.address;
            insmodelVm.Name = insmodel.Name;
            insmodelVm.salary = insmodel.salary;
            insmodelVm.imageUrl = insmodel.imageUrl;

            insmodelVm.Courses = courses;
            insmodelVm.crs_id = insmodel.crs_id;

            insmodelVm.Departments = departments;
            insmodelVm.deptId = insmodel.deptId;


            #endregion




            return View("Edit", insmodelVm);



        }


        public ActionResult saveEdit(InstructotwithlistDepartmentWithlistCourseViewModel insfromrequest)
        {
            // check all required fields 
            if (insfromrequest.Name != null && insfromrequest.imageUrl != null && insfromrequest.address != null && insfromrequest.salary != null && insfromrequest.crs_id != null && insfromrequest.deptId != null)
            {

                //getting current instructor from data base

                Instructor insmodel = instructorRepository.GetById(insfromrequest.Id);
                //mapping on insmodel 

                #region
                insmodel.Name = insfromrequest.Name;
                insmodel.imageUrl = insfromrequest.imageUrl;
                insmodel.address = insfromrequest.address;
                insmodel.salary = insfromrequest.salary;

                //foreign keys
                insmodel.crs_id = insfromrequest.crs_id;
                insmodel.deptId = insfromrequest.deptId;

                #endregion


                return RedirectToAction("All");

            }
            //adding lists
            insfromrequest.Courses= courseRepository.GetAll();
            insfromrequest.Departments = departmentRepository.GetAll();
            return View("Edit", insfromrequest);
        }



    }
}
