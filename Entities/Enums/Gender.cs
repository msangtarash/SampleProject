using System.ComponentModel.DataAnnotations;

namespace Entities.Enums;

public enum Gender
{
    [Display(Name = "مرد")]
    Male,
    [Display(Name = "رن")]
    Femail,
    [Display(Name = "سایر")]
    Others
}
