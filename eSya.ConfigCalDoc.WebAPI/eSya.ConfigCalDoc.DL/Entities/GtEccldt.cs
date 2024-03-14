using System;
using System.Collections.Generic;

namespace eSya.ConfigCalDoc.DL.Entities
{
    public partial class GtEccldt
    {
        public string CalenderKey { get; set; } = null!;
        public int MonthId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime TillDate { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; } = null!;
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedTerminal { get; set; }
    }
}
