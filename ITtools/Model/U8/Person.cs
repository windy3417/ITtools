namespace ITtools.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        [Key]
        [StringLength(20)]
        public string cPersonCode { get; set; }

        [StringLength(40)]
        public string cPersonName { get; set; }

        [Required]
        [StringLength(12)]
        public string cDepCode { get; set; }

        [StringLength(20)]
        public string cPersonProp { get; set; }

        public double? fCreditQuantity { get; set; }

        public int? iCreDate { get; set; }

        [StringLength(6)]
        public string cCreGrade { get; set; }

        public double? iLowRate { get; set; }

        [StringLength(20)]
        public string cOfferGrade { get; set; }

        public double? iOfferRate { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] pubufts { get; set; }

        [StringLength(100)]
        public string cPersonEmail { get; set; }

        [StringLength(100)]
        public string cPersonPhone { get; set; }

        public DateTime? dPValidDate { get; set; }

        public DateTime? dPInValidDate { get; set; }
    }
}
