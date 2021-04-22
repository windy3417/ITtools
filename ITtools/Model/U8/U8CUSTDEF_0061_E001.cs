namespace ITtools.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class U8CUSTDEF_0061_E001
    {
        [StringLength(40)]
        public string cNo { get; set; }

        [StringLength(30)]
        public string cMaker { get; set; }

        public DateTime? dMakeDateEx { get; set; }

        public DateTime? dMakeDate { get; set; }

        [StringLength(30)]
        public string cMender { get; set; }

        public DateTime? dModifyDateEx { get; set; }

        public DateTime? dModifyDate { get; set; }

        [StringLength(30)]
        public string cAuditor { get; set; }

        public DateTime? dAuditDateEx { get; set; }

        public DateTime? dAuditDate { get; set; }

        [StringLength(40)]
        public string U8CUSTDEF_0061_E001_F010 { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int U8CUSTDEF_0061_E001_PK { get; set; }

        public int? iswfcontrolled { get; set; }

        public int? iverifystate { get; set; }

        public int? ireturncount { get; set; }

        public int? UAPRuntime_RowNO { get; set; }

        [StringLength(50)]
        public string UAP_VoucherTransform_Rowkey { get; set; }
    }
}
