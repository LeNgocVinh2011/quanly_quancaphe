namespace Cafe_manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BILLINFO")]
    public partial class BILLINFO
    {
        [Key]
        public int info_Id { get; set; }

        public int b_Id { get; set; }

        public int f_Id { get; set; }

        public int count { get; set; }

        public int sum { get; set; }

        public virtual BILL BILL { get; set; }

        public virtual FRUID FRUID { get; set; }
    }
}
