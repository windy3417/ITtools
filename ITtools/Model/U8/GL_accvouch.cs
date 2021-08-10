namespace ITtools.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GL_accvouch
    {
        [Key]
        public int i_id { get; set; }

        public byte iperiod { get; set; }

        [StringLength(8)]
        public string csign { get; set; }

        public int? isignseq { get; set; }

        public short? ino_id { get; set; }

        public short inid { get; set; }

        public DateTime dbill_date { get; set; }

        public short idoc { get; set; }

        [StringLength(20)]
        public string cbill { get; set; }

        [StringLength(20)]
        public string ccheck { get; set; }

        [StringLength(20)]
        public string cbook { get; set; }

        public byte ibook { get; set; }

        [StringLength(20)]
        public string ccashier { get; set; }

        public byte? iflag { get; set; }

        [StringLength(10)]
        public string ctext1 { get; set; }

        [StringLength(10)]
        public string ctext2 { get; set; }

        [StringLength(120)]
        public string cdigest { get; set; }

        [Required]
        [StringLength(40)]
        public string ccode { get; set; }

        [StringLength(8)]
        public string cexch_name { get; set; }

        [Column(TypeName = "money")]
        public decimal md { get; set; }

        [Column(TypeName = "money")]
        public decimal mc { get; set; }

        [Column(TypeName = "money")]
        public decimal md_f { get; set; }

        [Column(TypeName = "money")]
        public decimal mc_f { get; set; }

        public double nfrat { get; set; }

        public double nd_s { get; set; }

        public double nc_s { get; set; }

        [StringLength(3)]
        public string csettle { get; set; }

        [StringLength(30)]
        public string cn_id { get; set; }

        public DateTime? dt_date { get; set; }

        [StringLength(12)]
        public string cdept_id { get; set; }

        [StringLength(20)]
        public string cperson_id { get; set; }

        [StringLength(20)]
        public string ccus_id { get; set; }

        [StringLength(20)]
        public string csup_id { get; set; }

        [StringLength(60)]
        public string citem_id { get; set; }

        [StringLength(2)]
        public string citem_class { get; set; }

        [StringLength(40)]
        public string cname { get; set; }

        [StringLength(50)]
        public string ccode_equal { get; set; }

        public byte? iflagbank { get; set; }

        public byte? iflagPerson { get; set; }

        public bool? bdelete { get; set; }

        [StringLength(3)]
        public string coutaccset { get; set; }

        public short? ioutyear { get; set; }

        [StringLength(10)]
        public string coutsysname { get; set; }

        [StringLength(10)]
        public string coutsysver { get; set; }

        public DateTime? doutbilldate { get; set; }

        public byte? ioutperiod { get; set; }

        [StringLength(100)]
        public string coutsign { get; set; }

        [StringLength(50)]
        public string coutno_id { get; set; }

        public DateTime? doutdate { get; set; }

        [StringLength(100)]
        public string coutbillsign { get; set; }

        [StringLength(50)]
        public string coutid { get; set; }

        public bool? bvouchedit { get; set; }

        public bool? bvouchAddordele { get; set; }

        public bool? bvouchmoneyhold { get; set; }

        public bool? bvalueedit { get; set; }

        public bool? bcodeedit { get; set; }

        [StringLength(50)]
        public string ccodecontrol { get; set; }

        public bool? bPCSedit { get; set; }

        public bool? bDeptedit { get; set; }

        public bool? bItemedit { get; set; }

        public bool? bCusSupInput { get; set; }

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

        public DateTime? dReceive { get; set; }

        [StringLength(1)]
        public string cWLDZFlag { get; set; }

        public DateTime? dWLDZTime { get; set; }

        public bool bFlagOut { get; set; }

        public int? iBG_OverFlag { get; set; }

        [StringLength(40)]
        public string cBG_Auditor { get; set; }

        public DateTime? dBG_AuditTime { get; set; }

        [StringLength(50)]
        public string cBG_AuditOpinion { get; set; }

        public bool? bWH_BgFlag { get; set; }

        public int? ssxznum { get; set; }

        [StringLength(512)]
        public string CErrReason { get; set; }

        [StringLength(512)]
        public string BG_AuditRemark { get; set; }

        [StringLength(10)]
        public string cBudgetBuffer { get; set; }

        public short? iBG_ControlResult { get; set; }

        [StringLength(60)]
        public string NCVouchID { get; set; }

        public DateTime? daudit_date { get; set; }

        [Required]
        [StringLength(60)]
        public string RowGuid { get; set; }

        [StringLength(30)]
        public string cBankReconNo { get; set; }

        public short? iyear { get; set; }

        public int? iYPeriod { get; set; }

        public DateTime? wllqDate { get; set; }

        public int? wllqPeriod { get; set; }

        public DateTime? tvouchtime { get; set; }

        [StringLength(50)]
        public string cblueoutno_id { get; set; }

        [StringLength(2000)]
        public string ccodeexch_equal { get; set; }
    }
}
