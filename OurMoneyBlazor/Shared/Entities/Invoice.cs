using System;

namespace OurMoneyBlazor.Shared.Entities
{
    public partial class Invoice
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int? MarketId { get; set; }

        public int AccountId { get; set; }

        public decimal? Discount { get; set; }

        public decimal Amount { get; set; }
    }
}
