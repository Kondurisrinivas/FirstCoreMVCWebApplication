namespace FirstCoreMVCWebApplication.Models
{
    public class StudentRepository : IStudentRepository
    {

        public StudentRepository()
        {
            String FilePath = @"C:\Raw_Development\TestStudent.txt";
            string contentToWrite = $"StudentRepository Object Created: @{DateTime.Now.ToString()}";
            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine(contentToWrite);
            }

        }
        public List<Student> DataSource()
        {
            return new List<Student>()
            {
                new Student() {StudentId=1146 , Name="Srinivas", Branch="ECE" , Gender="Male", Section="206" },
                new Student() {StudentId=1146 , Name="XXX", Branch="CSE" , Gender="FeMale", Section="111"}
            };
        }
        public Student GetStudentByID(int StudentID)
        {
            return DataSource().FirstOrDefault(e => e.StudentId == StudentID) ?? new Student();
        }

        public List<Student> GetAllStudents()
        {
            return DataSource();
        }
    }
}
