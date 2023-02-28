namespace ITtools.Model.IT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("addressBook")]
    public partial class addressBook
    {
        [StringLength(255)]
        public string department { get; set; }

        [StringLength(255)]
        public string engDepartment { get; set; }

        [StringLength(255)]
        public string englishName { get; set; }

        [StringLength(255)]
        public string chinessName { get; set; }

        public double? Ext { get; set; }

        public double? mobilePhoneNumber { get; set; }

        [StringLength(255)]
        public string MobilePhoneShortNumber { get; set; }

        [StringLength(255)]
        public string emailAddress { get; set; }

        public int ID { get; set; }

        [StringLength(10)]
        public string deptID { get; set; }

        [StringLength(10)]
        public string memoryCode { get; set; }
    }
}
