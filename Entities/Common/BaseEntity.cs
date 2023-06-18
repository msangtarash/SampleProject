using System.ComponentModel.DataAnnotations;

namespace Entities.Common
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTimeOffset ModifiedOn { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
