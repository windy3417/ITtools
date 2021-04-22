namespace ITtools.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// 科目预算对照表
    /// </summary>
    public partial class U8CUSTDEF_0061_E002
    {
        [StringLength(100)]
        public string U8CUSTDEF_0061_E002_F000 { get; set; }

        [StringLength(100)]
        public string U8CUSTDEF_0061_E002_F002 { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int U8CUSTDEF_0061_E002_PK { get; set; }

        public int? U8CUSTDEF_0061_E001_PK { get; set; }

        public int? UAPRuntime_RowNO { get; set; }

        [StringLength(50)]
        public string UAP_VoucherTransform_Rowkey { get; set; }

        [StringLength(50)]
        public string RefMainID { get; set; }

        [StringLength(50)]
        public string RefRowID { get; set; }
    }
}
