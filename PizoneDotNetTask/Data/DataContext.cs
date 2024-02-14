
using Microsoft.AspNetCore.Mvc;
using PizoneDotNetTask.Controllers;
using PizoneDotNetTask.Model;

namespace PizoneDotNetTask.Data
{
    public class DataContext : DbContext
    {
        internal readonly object UpdateSchool;

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        public DbSet<SchoolModel> Schools { get; set; }
        public DbSet<ClassModel> Classes { get; set; }
        public DbSet<StudentsModel> Students { get; set; }
        public object UpdateClass { get; internal set; }

        internal Task<ActionResult<List<ClassController>>> GetAllClasses()
        {
            throw new NotImplementedException();
        }

        internal Task<ActionResult<List<ClassController>>> GetAllSchool()
        {
            throw new NotImplementedException();
        }

        internal Task GetSingleClass(int id)
        {
            throw new NotImplementedException();
        }
    }
}



