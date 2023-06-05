namespace Cafe_manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BILL")]
    public partial class BILL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BILL()
        {
            BILLINFOes = new HashSet<BILLINFO>();
        }

        [Key]
        public int b_Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateCheckIn { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCheckOut { get; set; }

        public int tbl_Id { get; set; }

        public int status { get; set; }

        public int acc_Id { get; set; }

        public virtual TBL_STATUS TBL_STATUS { get; set; }
        public virtual ACCOUNT ACCOUNT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILLINFO> BILLINFOes { get; set; }
    }
}
