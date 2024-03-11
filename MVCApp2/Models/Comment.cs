using System;
using System.Collections.Generic;

namespace MVCApp2.Models;

public partial class Comment
{
    public int ProductId { get; set; }

    public string? Comments { get; set; }
}
