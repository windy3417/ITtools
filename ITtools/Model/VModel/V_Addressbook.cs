namespace ITtools.DAL.VModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_Addressbook
    {
        public string DeptId { get; set; }
        [StringLength(50)]
        public string deptName { get; set; }

        [StringLength(255)]
        public string chinessName { get; set; }

        public double? Ext { get; set; }

        public double? mobilePhoneNumber { get; set; }

        [StringLength(255)]
        public string emailAddress { get; set; }
    }
}
