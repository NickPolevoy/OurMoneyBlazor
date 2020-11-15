namespace OurMoneyBlazor.Shared.Entities
{
    public partial class Dictionary
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Amount { get; set; }

        public int? Rate { get; set; }

        public string Comment { get; set; }

        public int? ParentId { get; set; }

        public int EntityType { get; set; }

        public int? ImageId { get; set; }

        public bool? Hidden { get; set; }
    }
}
