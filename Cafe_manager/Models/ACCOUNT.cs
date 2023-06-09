namespace Cafe_manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [Key]
        public int acc_Id { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string DisplayName { get; set; }

        [Required]
        [StringLength(1000)]
        public string PassWord { get; set; }

        public int Type { get; set; }
    }
}
