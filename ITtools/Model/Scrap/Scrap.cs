namespace ITtools.Model.Scrap
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Scrap")]
    public partial class Scrap
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ScrapCode { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScrapID { get; set; }

        public string ScrapName { get; set; }

        public DateTime EffectDate { get; set; }

        public DateTime? FailuerDate { get; set; }
    }
}
