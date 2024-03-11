using System;
using System.Collections.Generic;

namespace MVCApp2.Models;

public partial class TblProduct
{
    public string? Name { get; set; }

    public string ProductCode { get; set; } = null!;

    public string? BrandName { get; set; }

    public int? StockLeft { get; set; }

    public decimal? Price { get; set; }

    public DateOnly? ExpiryDate { get; set; }
}
