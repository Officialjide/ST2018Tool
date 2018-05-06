using System;

namespace IceLux.Domain.Core
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public int FirmId { get; set; }
        public virtual Firm Firm { get; set; }
        public int? LocaltoCenter { get; set; }
        //public string MainUnit { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
