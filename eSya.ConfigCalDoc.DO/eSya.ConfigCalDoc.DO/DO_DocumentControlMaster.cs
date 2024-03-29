﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSya.ConfigCalDoc.DO
{
    public class DO_DocumentControlMaster
    {
        public int DocumentId { get; set; }
        public string DocumentDesc { get; set; } = null!;
        public string ShortDesc { get; set; } = null!;
        public string DocumentType { get; set; } = null!;
        public string? SchemaId { get; set; } = null!;
        public bool UsageStatus { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public int Isadd { get; set; }
    }
}
