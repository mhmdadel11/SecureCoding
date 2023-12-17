using SecureCoding.Attributes;
using System.ComponentModel.DataAnnotations;

namespace SecureCoding.Models;

public class Customer
{
  

    public int Id { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z]*$",
        ErrorMessage = "First Name must contain only letters")]
    [Display(Name = "First Name")]
    [StringLength(25, MinimumLength = 3)]
    public string FirstName { get; set; } = string.Empty;


    [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", 
        ErrorMessage = "Last Name must contain only letters")]
    [Display(Name = "Last Name")]
    //[StringLength(25, MinimumLength = 3)]
  
    public string LastName { get; set; } = string.Empty;


  
    public string Gender { get; set; } = string.Empty;

    [EmailAddress]
    [ReputableEmail]
    public string Email { get; set; } = string.Empty;

  
   
}