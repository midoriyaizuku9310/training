using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCApp2.Models;

public partial class Cart
{
    public string UserName { get; set; } = null!;

    public string? Name { get; set; }

    public int? ProductId { get; set; }

    [Key]
    public int Id { get; set; }

    public string? Price { get; set; }
}
