using FirstCoreMVCWebApplication.Models;
using FirstCoreMVCWebApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstCoreMVCWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Details()
        {
            Student student = new Student()
            {
                StudentId = 101,
                Name = "James",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };

            StudentAddress studentAddress = new StudentAddress()
            {
                StudentID = 102,
                Country = "India",
                City = "Bangalore",
                State = "Karnataka",
                PinCode = "560001"
            };  
            
            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
            {
                Student_Details = student,
                Student_Address = studentAddress,
                Title = "Student Details Page",
                Header = "Student Details",
            };

            return View(studentDetailsViewModel);
        }
        //private readonly IStudentRepository? _repository = null;
        //private readonly SomeOtherService? _someOtherService = null;
        //public HomeController(IStudentRepository repository, SomeOtherService someOtherService)
        //{
        //    _repository = repository;
        //    _someOtherService = someOtherService;
        //}
        //public JsonResult Index()
        //{
        //    StudentRepository repository = new StudentRepository();
        //    List<Student> allStudentDetails = repository.GetAllStudents();
        //    return Json(allStudentDetails);
        //}
        //public JsonResult GetStudentDetails(int Id)
        //{
        //    StudentRepository repository = new StudentRepository();
        //    Student studentDetails = repository.GetStudentByID(Id);
        //    return Json(studentDetails);

        //}
    }
}
