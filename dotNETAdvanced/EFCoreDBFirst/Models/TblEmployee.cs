using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models;

public partial class TblEmployee
{
    public int Eid { get; set; }

    public string? Ename { get; set; }

    public int? Salary { get; set; }

    public int? Deptid { get; set; }
}
