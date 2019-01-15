namespace SMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Exam_Result
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int ExamId { get; set; }

        public byte Result { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual Student Student { get; set; }
    }
}
