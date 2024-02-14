using PizoneDotNetTask.Controllers;

namespace PizoneDotNetTask.Services.ClassService
{
    public interface IClassService
    {
        List<ClassController> GetAllClasses();  
        ClassController GetSingleClass(int id);

    }
}
