﻿using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class EsImUserContact
    {
        public int UserId { get; set; }
        public int ContactId { get; set; }
        public string Alias { get; set; }
        public string GrpName { get; set; }
    }
}
