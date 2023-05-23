namespace Api.Data.Entities
{
    public class Receipt
    {
        public int Id { get; set; }
        public DateTime ReceiptDate { get; set; }
        public string Item { get; set; } = string.Empty;
        public int Quantity { get; set; }

    }
}
