﻿namespace GeekShopping.OrderAPI.Messages
{
    public class UpdatePaymentResultVO
    {
        public long OrderID { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
    }
}
