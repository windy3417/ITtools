namespace ITtools.Model.IT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebUrl")]
    public partial class WebUrl
    {
        public int id { get; set; }

        public string introduction { get; set; }

        public string url { get; set; }

        public int ResourceClass { get; set; }
    }
}
