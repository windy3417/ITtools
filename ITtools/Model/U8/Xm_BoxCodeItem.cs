namespace ITtools.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Xm_BoxCodeItem
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string BoxCode { get; set; }

        [Required]
        [StringLength(50)]
        public string NaturalFlowCode { get; set; }

        [StringLength(50)]
        public string DateFlowCode { get; set; }

        public decimal? Qty { get; set; }

        [StringLength(10)]
        public string cPackingType { get; set; }

        public int? PrintCount { get; set; }

        public virtual Xm_BoxCode Xm_BoxCode { get; set; }
    }
}
