using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class courseViewmodel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int degree { get; set; }
        public int minDegree { get; set; }
        public int hours { get; set; }


        public string Department { get; set; }

    }
}
