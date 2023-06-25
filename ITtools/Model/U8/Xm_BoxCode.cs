namespace ITtools.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Xm_BoxCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Xm_BoxCode()
        {
            Xm_BoxCodeItem = new HashSet<Xm_BoxCodeItem>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(50)]
        public string BoxCode { get; set; }

        [StringLength(20)]
        public string dDate { get; set; }

        public int? MoId { get; set; }

        public int? MoDId { get; set; }

        [StringLength(50)]
        public string MoCode { get; set; }

        public int? MoSeq { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MakeDate { get; set; }

        [StringLength(10)]
        public string MDept { get; set; }

        [StringLength(20)]
        public string DeptName { get; set; }

        [Required]
        [StringLength(50)]
        public string InvCode { get; set; }

        [StringLength(50)]
        public string InvName { get; set; }

        [StringLength(50)]
        public string InvStd { get; set; }

        [StringLength(10)]
        public string UnitId { get; set; }

        [StringLength(10)]
        public string UnitCode { get; set; }

        public decimal? Qty { get; set; }

        [StringLength(10)]
        public string cPackingType { get; set; }

        [StringLength(50)]
        public string PrintName { get; set; }

        [StringLength(50)]
        public string CreateUserCode { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Xm_BoxCodeItem> Xm_BoxCodeItem { get; set; }
    }
}
