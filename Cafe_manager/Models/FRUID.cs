namespace Cafe_manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FRUID")]
    public partial class FRUID
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FRUID()
        {
            BILLINFOes = new HashSet<BILLINFO>();
        }

        [Key]
        public int f_Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int cat_Id { get; set; }

        public double Price { get; set; }
        [StringLength(1000)]
        public string imgPath { get; set; }

        public int isDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILLINFO> BILLINFOes { get; set; }

        public virtual FRUID_CATEGORIES FRUID_CATEGORIES { get; set; }
    }
}
