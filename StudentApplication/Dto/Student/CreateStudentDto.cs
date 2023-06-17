namespace StudentApplication.Dto.Student
{
    public class CreateStudentDto
    {
        public string Name { set; get; }
        public string StudentCode { set; get; }
        public DateOnly DateOfBirth { set; get; }
    }
}
