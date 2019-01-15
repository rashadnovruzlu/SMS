namespace SMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_Information
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int GroupId { get; set; }

        [Required]
        [StringLength(7)]
        public string PIN { get; set; }

        [Required]
        [StringLength(10)]
        public string CN { get; set; }

        [StringLength(9)]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime EnteredDate { get; set; }

        public virtual Group Group { get; set; }

        public virtual Student Student { get; set; }
    }
}
