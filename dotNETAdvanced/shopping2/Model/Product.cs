using System;
using System.Collections.Generic;

namespace shopping2.Model;

public partial class Product
{
    public int Id { get; set; }

    public byte[] Image { get; set; } = null!;
    public string Path { get; set; }
}
