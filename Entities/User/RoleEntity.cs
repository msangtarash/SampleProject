using System.ComponentModel.DataAnnotations;
using Entities.Common;

namespace Entities.User;

public class RoleEntity : BaseEntity
{
    [Required]
    [StringLength(100)]
    public string? Name { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }
}
