namespace ITtools.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PU_AppVouchs
    {
        public int ID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AutoID { get; set; }

        [StringLength(20)]
        public string cVenCode { get; set; }

        [Required]
        [StringLength(60)]
        public string cInvCode { get; set; }

        public decimal fQuantity { get; set; }

        public decimal? fUnitPrice { get; set; }

        public decimal? iPerTaxRate { get; set; }

        public decimal? fTaxPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? fMoney { get; set; }

        public DateTime? dRequirDate { get; set; }

        public DateTime? dArriveDate { get; set; }

        public decimal? iReceivedQTY { get; set; }

        [StringLength(20)]
        public string cFree1 { get; set; }

        [StringLength(20)]
        public string cFree2 { get; set; }

        [StringLength(20)]
        public string cFree3 { get; set; }

        [StringLength(20)]
        public string cFree4 { get; set; }

        [StringLength(20)]
        public string cFree5 { get; set; }

        [StringLength(20)]
        public string cFree6 { get; set; }

        [StringLength(20)]
        public string cFree7 { get; set; }

        [StringLength(20)]
        public string cFree8 { get; set; }

        [StringLength(20)]
        public string cFree9 { get; set; }

        [StringLength(20)]
        public string cFree10 { get; set; }

        [StringLength(60)]
        public string cDefine22 { get; set; }

        [StringLength(60)]
        public string cDefine23 { get; set; }

        [StringLength(60)]
        public string cDefine24 { get; set; }

        [StringLength(60)]
        public string cDefine25 { get; set; }

        public double? cDefine26 { get; set; }

        public double? cDefine27 { get; set; }

        [StringLength(120)]
        public string cDefine28 { get; set; }

        [StringLength(120)]
        public string cDefine29 { get; set; }

        [StringLength(120)]
        public string cDefine30 { get; set; }

        [StringLength(120)]
        public string cDefine31 { get; set; }

        [StringLength(120)]
        public string cDefine32 { get; set; }

        [StringLength(120)]
        public string cDefine33 { get; set; }

        public int? cDefine34 { get; set; }

        public int? cDefine35 { get; set; }

        public DateTime? cDefine36 { get; set; }

        public DateTime? cDefine37 { get; set; }

        [StringLength(2)]
        public string cItem_class { get; set; }

        [StringLength(60)]
        public string cItemCode { get; set; }

        [StringLength(255)]
        public string CItemName { get; set; }

        public bool? bTaxCost { get; set; }

        public int? iPPartId { get; set; }

        public decimal? iPQuantity { get; set; }

        public int? iPTOSeq { get; set; }

        [StringLength(10)]
        public string cSource { get; set; }

        [StringLength(50)]
        public string SoDId { get; set; }

        public byte? SoType { get; set; }

        public int? iMrpsid { get; set; }

        public int? iRopsid { get; set; }

        [StringLength(20)]
        public string cbcloser { get; set; }

        public decimal? fNum { get; set; }

        [StringLength(35)]
        public string cUnitID { get; set; }

        public decimal? iReceivedNum { get; set; }

        [StringLength(20)]
        public string cPersonCodeExec { get; set; }

        [StringLength(20)]
        public string cDepCodeExec { get; set; }

        public decimal? iInvMPCost { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] dUfts { get; set; }

        [Required]
        [StringLength(8)]
        public string cexch_name { get; set; }

        public decimal? iExchRate { get; set; }

        public decimal? iOriCost { get; set; }

        public decimal? iOriTaxCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? iOriMoney { get; set; }

        [Column(TypeName = "money")]
        public decimal? iOriTaxPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? iOriSum { get; set; }

        [Column(TypeName = "money")]
        public decimal? iMoney { get; set; }

        [Column(TypeName = "money")]
        public decimal? iTaxPrice { get; set; }

        [StringLength(50)]
        public string cdemandcode { get; set; }

        [StringLength(100)]
        public string cdetailsdemandmemo { get; set; }

        [StringLength(50)]
        public string cBG_ItemCode { get; set; }

        [StringLength(100)]
        public string cBG_ItemName { get; set; }

        [StringLength(50)]
        public string cBG_CaliberKey1 { get; set; }

        [StringLength(100)]
        public string cBG_CaliberKeyName1 { get; set; }

        [StringLength(50)]
        public string cBG_CaliberKey2 { get; set; }

        [StringLength(100)]
        public string cBG_CaliberKeyName2 { get; set; }

        [StringLength(50)]
        public string cBG_CaliberKey3 { get; set; }

        [StringLength(100)]
        public string cBG_CaliberKeyName3 { get; set; }

        [StringLength(90)]
        public string cBG_CaliberCode1 { get; set; }

        [StringLength(100)]
        public string cBG_CaliberName1 { get; set; }

        [StringLength(90)]
        public string cBG_CaliberCode2 { get; set; }

        [StringLength(100)]
        public string cBG_CaliberName2 { get; set; }

        [StringLength(90)]
        public string cBG_CaliberCode3 { get; set; }

        [StringLength(100)]
        public string cBG_CaliberName3 { get; set; }

        public byte? iBG_Ctrl { get; set; }

        [StringLength(100)]
        public string cBG_Auditopinion { get; set; }

        [StringLength(40)]
        public string mocode { get; set; }

        public int? ivouchrowno { get; set; }

        public decimal? fconquantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? fconmoney { get; set; }

        public decimal? fconnum { get; set; }

        [Column(TypeName = "money")]
        public decimal? fconorimoney { get; set; }

        [StringLength(50)]
        public string cBG_CaliberKey4 { get; set; }

        [StringLength(100)]
        public string cBG_CaliberKeyName4 { get; set; }

        [StringLength(50)]
        public string cBG_CaliberKey5 { get; set; }

        [StringLength(100)]
        public string cBG_CaliberKeyName5 { get; set; }

        [StringLength(50)]
        public string cBG_CaliberKey6 { get; set; }

        [StringLength(100)]
        public string cBG_CaliberKeyName6 { get; set; }

        [StringLength(90)]
        public string cBG_CaliberCode4 { get; set; }

        [StringLength(100)]
        public string cBG_CaliberName4 { get; set; }

        [StringLength(90)]
        public string cBG_CaliberCode5 { get; set; }

        [StringLength(100)]
        public string cBG_CaliberName5 { get; set; }

        [StringLength(90)]
        public string cBG_CaliberCode6 { get; set; }

        [StringLength(100)]
        public string cBG_CaliberName6 { get; set; }

        [StringLength(40)]
        public string csocode { get; set; }

        public int? irowno { get; set; }

        public decimal? iSumXJqty { get; set; }

        public decimal? iSumXJCGqty { get; set; }

        public DateTime? dbCloseDate { get; set; }

        public DateTime? dbCloseTime { get; set; }

        [StringLength(255)]
        public string cbMemo { get; set; }

        [StringLength(80)]
        public string cbsysbarcode { get; set; }

        public int? isosid { get; set; }

        public int? iorderdid { get; set; }

        public byte? iordertype { get; set; }

        [StringLength(50)]
        public string csoordercode { get; set; }

        public int? iorderseq { get; set; }

        [StringLength(40)]
        public string planlotnumber { get; set; }
    }
}
