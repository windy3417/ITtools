namespace ITtools.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// ‘§À„œÓƒø
    /// </summary>
    public partial class U8CUSTDEF_0044_E002
    {
        [StringLength(40)]
        public string cNo { get; set; }

        [StringLength(200)]
        public string cCardName { get; set; }

        [StringLength(30)]
        public string cMaker { get; set; }

        public DateTime? dMakeDateEx { get; set; }

        public DateTime? dMakeDate { get; set; }

        [StringLength(30)]
        public string cMender { get; set; }

        public DateTime? dModifyDateEx { get; set; }

        public DateTime? dModifyDate { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int U8CUSTDEF_0044_E002_PK { get; set; }

        public int? U8CUSTDEF_0043_E001_PK { get; set; }

        public int? UAPRuntime_RowNO { get; set; }

        [StringLength(50)]
        public string RefMainID { get; set; }

    
        [StringLength(50)]
        public string RefRowID { get; set; }
    }
}
