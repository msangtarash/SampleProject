using System.ComponentModel.DataAnnotations;
using Entities.Common;

namespace Entities.Post;

public class CategoryEntity : BaseEntity
{
    [Required]
    [StringLength(100)]
    public string? Name { get; set; }
    public Guid? ParentId { get; set; }
    public CategoryEntity? Parent { get; set; }
    public ICollection<CategoryEntity> Childs { get; set; } = new List<CategoryEntity>();
    public ICollection<PostEntity> Posts { get; set; } = new List<PostEntity>();
}
