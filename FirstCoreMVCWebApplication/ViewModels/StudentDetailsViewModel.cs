using FirstCoreMVCWebApplication.Models;

namespace FirstCoreMVCWebApplication.ViewModels
{
    public class StudentDetailsViewModel
    {
        public Student? Student_Details { get; set; }
        public StudentAddress? Student_Address { get; set; }
        public string? Title { get; set; }
        public string? Header { get; set; }
    }
}
