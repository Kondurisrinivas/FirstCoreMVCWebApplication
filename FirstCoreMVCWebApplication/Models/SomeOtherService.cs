namespace FirstCoreMVCWebApplication.Models
{
    public class SomeOtherService
    { 
        private readonly IStudentRepository? _repository;
        public SomeOtherService(IStudentRepository repository)
        {
            _repository = repository;

        }

        public void someMethod()
        {
            //
        }
    }
}