using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Common;
using Entities.User;

namespace Entities.Post;

public class PostEntity : BaseEntity
{
    [Required]
    [StringLength(100)]
    public string? Title { get; set; }
    public string? Description { get; set; }
    public Guid CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))]
    public CategoryEntity? Category { get; set; }
    public Guid AuthorId { get; set; }
    [ForeignKey(nameof(AuthorId))]
    public UserEntity? Author { get; set; }
}
