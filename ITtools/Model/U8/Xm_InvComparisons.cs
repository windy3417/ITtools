namespace ITtools.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Xm_InvComparisons
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string cInvCode { get; set; }

        public int? initCode { get; set; }

        public int? maxCode { get; set; }

        [StringLength(50)]
        public string dateMaxCode { get; set; }
    }
}
