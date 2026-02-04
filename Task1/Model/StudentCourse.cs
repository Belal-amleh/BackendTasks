using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task1.Model
{
    public class StudentCourse
    {
        // 1 student many to SudentCourses
        // many StudentCourse to 1 course

        [Key]
        public Guid Id { set; get; } = Guid.NewGuid();

        [Required]
        public Guid studentId { get; set; }

        [ForeignKey("studentId")]
        public Student Student { get; set; }

        [Required]
        public Guid CourseId { set; get; }

        [ForeignKey("CourseId")]
        public Course Course { set; get; }


    }
}
