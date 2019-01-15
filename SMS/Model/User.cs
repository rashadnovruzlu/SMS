namespace SMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string UserName { get; set; }

        [Required]
        [StringLength(32)]
        public string Password { get; set; }

        public bool Status { get; set; }
    }
}
