using WebApplication1.Models;

namespace WebApplication1.Repository.ImodelRepository
{
    public interface ICraResultRepository 
    {

       //return complex obj having info of trainee and course

        object getByCrsidAndTrainid(int courseid,int traineeid);



    }
}