namespace ITtools.Model.IT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public partial class Department
    {
        public int id { get; set; }

        [StringLength(4)]
        public string deptID { get; set; }

        [Required]
        [StringLength(50)]
        public string deptName { get; set; }

        public string EnglishName { get; set; }
    }
}
