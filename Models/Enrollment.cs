using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace IITUniversity.Models
{
    public enum Grade
    {
        Distinction,
        FirstClass,
        SecondClass,
        ThirdClass,
        Fail
    }
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        [ForeignKey("StudentID")]
        public Student Student { get; set; }

        [ForeignKey("CourseID")]
        public Course Course { get; set; }
    }
}
