using System;

namespace OurMoneyBlazor.Shared.Entities
{
    public partial class Event
    {
        public int Id { get; set; }

        public int OperationType { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public string Comment { get; set; }

        public int CategoryId { get; set; }

        public int InvoiceId { get; set; }

        public int? AccountId { get; set; }
    }
}
