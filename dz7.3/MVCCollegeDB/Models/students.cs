namespace MVCCollegeDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class students
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public students()
        {
            marks = new HashSet<marks>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int roll_num { get; set; }

        [Required]
        [StringLength(25)]
        public string first_name { get; set; }

        [Required]
        [StringLength(25)]
        public string last_name { get; set; }

        public int? department_id { get; set; }

        [StringLength(10)]
        public string phone { get; set; }

        [Column(TypeName = "date")]
        public DateTime admission_date { get; set; }

        public int cet_marks { get; set; }

        public virtual departments departments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<marks> marks { get; set; }
    }
}
