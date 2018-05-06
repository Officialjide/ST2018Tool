namespace IceLux.Domain.Core
{
    public class TakeDetail
    {
        public int TakeDetailId { get; set; }
        public int TakeId { get; set; }
        public virtual Take Take { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public string DetailBreakDown { get; set; }
        public decimal Quantiy { get; set; }
        public bool? IsMainUnit { get; set; }
    }
}
