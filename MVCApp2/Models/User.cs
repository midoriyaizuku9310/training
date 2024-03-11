using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCApp2.Models;

public partial class User
{
    
    [Key]
    [Required]
    public string UserName { get; set; } = null!;


    public string AuthType { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;

    [Required]
    public string Email { get; set; } = null!;

    [Required]
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(10)]
    [MinLength(10)]
    public string PhoneNumber { get; set; } = null!;
}
