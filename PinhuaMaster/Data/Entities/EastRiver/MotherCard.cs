using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class MotherCard
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Pin1 { get; set; }
        public string Pin2 { get; set; }
        public bool WashCardFlag { get; set; }
        public string CompanyId { get; set; }
        public string VerId { get; set; }
        public string CardKind { get; set; }
        public string UseType { get; set; }
        public string DeviceNo { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
    }
}
