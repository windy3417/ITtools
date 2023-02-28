namespace ITtools.Model.IT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Directory")]
    public partial class Directory
    {
        public string directoryID { get; set; }

        public string diretory { get; set; }

        public string directoryType { get; set; }
    }
}
