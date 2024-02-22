using System;
using System.Collections.Generic;

namespace BookWorm_DotNet.Models;

public partial class InvoiceDetail
{
    public long InvoiceDetailId { get; set; }

    public double BasePrice { get; set; }

    public int RentDays { get; set; }

    public double SalePrice { get; set; }

    public string TransactionType { get; set; } = null!;

    public long InvoiceId { get; set; }

    public long ProductId { get; set; }

    public int Quantity { get; set; }

    public virtual Invoice Invoice { get; set; }

    public virtual Product Product { get; set; }
}
