namespace ITtools.Model.IT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrWeakCurrent")]
    public partial class PrWeakCurrent
    {
        [Key]
        [Column(Order = 0)]
        public string PrVoucherNo { get; set; }

        public string projectContent { get; set; }

        public DateTime PrDate { get; set; }

        public string PrPerson { get; set; }

        public bool? isSettle { get; set; }

        public DateTime? settleDate { get; set; }

        public bool? UpLoadFlag { get; set; }

        public int? SendEmailAmount { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RowID { get; set; }
    }
}
