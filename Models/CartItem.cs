using System;
using System.Collections.Generic;

namespace WebShopDACS.Models;

public partial class CartItem
{
    public int CartId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public int UserId { get; set; }

    public decimal TotalPrice { get; set; }

    public virtual User User { get; set; } = null!;
}
