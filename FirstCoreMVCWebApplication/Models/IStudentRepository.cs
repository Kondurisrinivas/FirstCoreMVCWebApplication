namespace FirstCoreMVCWebApplication.Models
{
    public interface IStudentRepository
    {
        Student GetStudentByID(int StudentID);
        List<Student> GetAllStudents(); 
    }
}
