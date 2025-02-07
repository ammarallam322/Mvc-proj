



namespace WebApplication1.ViewModel
{
    public class TraineeWithCourseResultViewModel
    {

        public TraineeWithCourseResultViewModel()
        {
            
        }
        public TraineeWithCourseResultViewModel(int traineeId, int courseId, string traineeName, string coursNName, int grade, string color="green")
        {
            this.traineeId = traineeId;
            this.courseId = courseId;
            this.traineeName = traineeName;
            this.coursNName = coursNName;
            this.grade = grade;
            this.color = color;
        }

        public int traineeId {  get; set; }
        public int courseId {  get; set; }
        public string traineeName { get; set; }
        public string coursNName { get; set; }//????????????
        public int grade {  get; set; }
        public string color { get; set; } = "green";





    }
}
