namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [Key]
        [Column("AccountNumber")]
        [StringLength(50)]
        public string AccountNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
