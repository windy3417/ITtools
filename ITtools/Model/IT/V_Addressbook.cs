namespace ITtools.Model.IT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_Addressbook
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AddressBookID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string deptID { get; set; }

        [Key]
        [Column(Order = 2)]
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
