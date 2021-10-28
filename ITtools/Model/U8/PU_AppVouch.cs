namespace ITtools.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PU_AppVouch
    {
        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] ufts { get; set; }

        public int iVTid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string cCode { get; set; }

        public DateTime dDate { get; set; }

        [StringLength(12)]
        public string cDepCode { get; set; }

        [StringLength(20)]
        public string cPersonCode { get; set; }

        [StringLength(2)]
        public string cPTCode { get; set; }

        [StringLength(8)]
        public string cBusType { get; set; }

        [StringLength(20)]
        public string cMaker { get; set; }

        [StringLength(20)]
        public string cVerifier { get; set; }

        [StringLength(20)]
        public string cCloser { get; set; }

        [StringLength(20)]
        public string cDefine1 { get; set; }

        [StringLength(20)]
        public string cDefine2 { get; set; }

        [StringLength(20)]
        public string cDefine3 { get; set; }

        public DateTime? cDefine4 { get; set; }

        public int? cDefine5 { get; set; }

        public DateTime? cDefine6 { get; set; }

        public double? cDefine7 { get; set; }

        [StringLength(4)]
        public string cDefine8 { get; set; }

        [StringLength(8)]
        public string cDefine9 { get; set; }

        [StringLength(60)]
        public string cDefine10 { get; set; }

        [StringLength(120)]
        public string cDefine11 { get; set; }

        [StringLength(120)]
        public string cDefine12 { get; set; }

        [StringLength(120)]
        public string cDefine13 { get; set; }

        [StringLength(120)]
        public string cDefine14 { get; set; }

        public int? cDefine15 { get; set; }

        public double? cDefine16 { get; set; }

        [StringLength(255)]
        public string cMemo { get; set; }

        [StringLength(20)]
        public string cLocker { get; set; }

        public int? iverifystateex { get; set; }

        public int? ireturncount { get; set; }

        public bool? IsWfControlled { get; set; }

        public DateTime? cMakeTime { get; set; }

        public DateTime? cModifyTime { get; set; }

        public DateTime? cAuditTime { get; set; }

        public DateTime? cAuditDate { get; set; }

        public DateTime? cModifyDate { get; set; }

        [StringLength(40)]
        public string cReviser { get; set; }

        [StringLength(20)]
        public string cchanger { get; set; }

        public short? iBG_OverFlag { get; set; }

        [StringLength(20)]
        public string cBG_Auditor { get; set; }

        [StringLength(20)]
        public string cBG_AuditTime { get; set; }

        public short? ControlResult { get; set; }

        public int? iflowid { get; set; }

        public int? iPrintCount { get; set; }

        [StringLength(50)]
        public string ccleanver { get; set; }

        public DateTime? dCloseDate { get; set; }

        public DateTime? dCloseTime { get; set; }

        [StringLength(60)]
        public string csysbarcode { get; set; }

        [StringLength(200)]
        public string cCurrentAuditor { get; set; }

        [StringLength(40)]
        public string cChangVerifier { get; set; }

        public DateTime? cChangAuditTime { get; set; }

        public DateTime? cChangAuditDate { get; set; }
    }
}
