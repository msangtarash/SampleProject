using Entities.Common;
using Entities.Enums;
using Entities.Post;
using System.ComponentModel.DataAnnotations;

namespace Entities.User
{
    public class UserEntity : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string? UserName { get; set; }

        [Required]
        [StringLength(500)]
        public string? Password { get; set; }
        public string? FullName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public bool IsActive { get; set; }
        public ICollection<PostEntity> Posts { get; set; } = new List<PostEntity>();

    }
}
