namespace ITtools.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Xm_AccInformation
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Name { get; set; }

        public int? MaxValue { get; set; }

        public int? Length { get; set; }

        public int? DefaultValue { get; set; }

        [StringLength(10)]
        public string Prefix { get; set; }
    }
}
