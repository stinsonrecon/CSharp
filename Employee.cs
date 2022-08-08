using System;
using System.ComponentModel.DataAnnotations;

public class Employee{
    [Required (ErrorMessage = "Employee {0} is required")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Ten tu 3 den 100 ky tu")]
    [DataType (DataType.Text)]
    public string Name { get; set; }

    [Range (18,99, ErrorMessage = "Age should be between 19 and 99")]
    public int Age { get; set; }

    [DataType (DataType.PhoneNumber)]
    [Phone]
    public string PhoneNum { get; set; }

    [DataType (DataType.EmailAddress)]
    [EmailAddress]
    public string Email { get; set; }
}