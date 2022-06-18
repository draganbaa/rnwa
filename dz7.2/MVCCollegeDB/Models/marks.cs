namespace MVCCollegeDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class marks
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int student_roll_num { get; set; }

        public int subject_id { get; set; }

        [Column("marks")]
        public int marks1 { get; set; }

        public virtual students students { get; set; }

        public virtual subjects subjects { get; set; }
    }
}
