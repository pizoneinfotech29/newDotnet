namespace PizoneDotNetTask.Model
{
    public class ClassModel
    {
        internal object NumberOfStudents;

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string NoOfStudent { get; set; } = string.Empty;  
        public string School { get; set; } = string.Empty;
       // public object NumberOfStudents { get; internal set; }
        //public object? NumberOfStudents { get; internal set; }
    }
}
