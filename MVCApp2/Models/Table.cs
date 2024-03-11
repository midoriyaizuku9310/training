using System;
using System.Collections.Generic;

namespace MVCApp2.Models;

public partial class Table
{
    public int Id { get; set; }

    public string? CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? SubCategoryId { get; set; }

    public string? SubCategiryName { get; set; }

    public string? ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? Price { get; set; }

    public string? Rating { get; set; }

    public byte[]? Image { get; set; }
}
