using System;
using System.Collections.Generic;

namespace MVCApp2.Models;

public partial class Payment
{
    public int UserName { get; set; }

    public string? CardId { get; set; }

    public int? Cvv { get; set; }

    public int? Balance { get; set; }
}
