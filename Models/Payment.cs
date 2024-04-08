using System;
using System.Collections.Generic;

namespace WebShopDACS.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public DateTime PaymentDate { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public decimal Amount { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
