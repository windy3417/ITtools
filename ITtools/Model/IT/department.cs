namespace ITtools.Model.IT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("department")]
    public partial class department
    {
        [Key]
        [StringLength(4)]
        public string deptID { get; set; }

        [Required]
        [StringLength(50)]
        public string deptName { get; set; }
        public string EnglishName { get; set; }
    }
}
