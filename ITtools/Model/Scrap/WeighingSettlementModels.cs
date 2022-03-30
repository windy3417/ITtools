namespace ITtools.Model.Scrap
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WeighingSettlementModels
    {
        [Key]
        public string vocherNO { get; set; }

        public DateTime MakeDate { get; set; }

        public DateTime WeighingDate { get; set; }

        public string CustmerCode { get; set; }

        public string personCode { get; set; }

        public string scrapCode { get; set; }

        public double GrossWeght { get; set; }

        //ЦЄжи
        public double Tare { get; set; }

        public string VehicleBrand { get; set; }

        public double netWeight { get; set; }

        public double proportion { get; set; }

        public double webUnitPrice { get; set; }

        public double settleUnitPrice { get; set; }

        public double settleAmount { get; set; }

        public string WeightingTime { get; set; }

        public int auditFlag { get; set; }

        public string note { get; set; }
    }
}
