using System.ComponentModel.DataAnnotations;

namespace Task1.Model
{
    public class Student
    {
        [Key]
        public Guid Id { set; get; } = Guid.NewGuid();

        [Required]
        [MaxLength(20)]
        public string name { set; get; }

        public List<StudentCourse> studentCourses = new List<StudentCourse>();
                
    }
}
