using System.ComponentModel.DataAnnotations;

namespace Task1.Model
{
    public class Course
    {
        [Key]
        public Guid Id { set; get; } = Guid.NewGuid();

        [Required]
        [MaxLength(20)]
        public string Name { set; get; }

        public List<StudentCourse> studentCourses = new List<StudentCourse>();

    }
}
