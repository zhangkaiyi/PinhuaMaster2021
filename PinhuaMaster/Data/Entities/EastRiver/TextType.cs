using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class TextType
    {
        public int Id { get; set; }
        public string Texttypename { get; set; }
        public string Textmemo { get; set; }
        public int? TextKind { get; set; }
        public int? UseKind { get; set; }
    }
}
