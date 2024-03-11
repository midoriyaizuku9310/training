using System;
using System.Collections.Generic;

namespace practice2.Models;

public partial class Student
{
    public string LastName { get; set; } = null!;

    public string? FirstMidName { get; set; }

    public DateOnly? EnrollmentData { get; set; }
}
