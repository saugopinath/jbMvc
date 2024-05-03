using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JbMvc.Models;

public class AppUser : IdentityUser
{
    [StringLength(100)]
    [MaxLength(100)]
    [Required]
    public string? Name { get; set; }
    public string? Address { get; set; }
    [Column(TypeName = "char(10)")]
    [Required]
    public string? mobile_no { get; set; }
   
}
