namespace SMS.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Student")]
    public partial class Student
    {
        public Student()
        {
            Exam_Result = new HashSet<Exam_Result>();
            Student_Information = new HashSet<Student_Information>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        [StringLength(25)]
        public string Surname { get; set; }

        [Required]
        [StringLength(25)]
        public string FatherName { get; set; }

        public byte SexId { get; set; }

        public virtual ICollection<Exam_Result> Exam_Result { get; set; }

        public virtual Sex Sex { get; set; }

        public virtual ICollection<Student_Information> Student_Information { get; set; }
    }
}
