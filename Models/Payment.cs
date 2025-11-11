using no12finalproject.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace no12finalproject.Models
{
    public class Payment
    {

        public Guid PaymentID { get; set; }

        [Required]
        public DateTime PaymentTime { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public Guid OrderID { get; set; }

        [Required]
        public Guid PaymentMethodID { get; set; }

        public Order Order { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

    }
}
