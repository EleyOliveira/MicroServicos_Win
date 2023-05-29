namespace GeekShopping.Email.Messages
{
    public class UpdatePaymentResultMessage
    {
        public long OrderID { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
    }
}
