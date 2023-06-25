namespace ITtools.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Xm_InvComparison
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string cInvCode { get; set; }

        [StringLength(50)]
        public string cInvName { get; set; }

        [StringLength(50)]
        public string cInvStd { get; set; }

        [StringLength(20)]
        public string PrintName { get; set; }

        [StringLength(10)]
        public string cPackingType { get; set; }

        public int? initCode { get; set; }

        public int? maxCode { get; set; }

        public bool Disabled { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserCode { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        [StringLength(50)]
        public string dateMaxCode { get; set; }

        [Required]
        [StringLength(50)]
        public string pk_code { get; set; }
    }
}
