using System.ComponentModel.DataAnnotations;
using WebApplication1.ViewModel;

namespace WebApplication1.Models
{
    public class courseUniqueNameAttribute : ValidationAttribute
    {



        protected override ValidationResult? IsValid
            (object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("name required");
            }
            string name = value.ToString();

            MVCProjectContext context = new MVCProjectContext();
            //come from request
            CourseWithdepartmentsViewModel crsFromREquest = (CourseWithdepartmentsViewModel)validationContext.ObjectInstance;

            //come from Databse
            Course crsfromdatabase = context.Course
                .FirstOrDefault(e => e.Name == name && e.deptId == crsFromREquest.deptId);


            if (crsfromdatabase == null)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult($"Name {name} Already Exists");
        }

    }
}
