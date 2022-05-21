using System.ComponentModel.DataAnnotations;

namespace Domain.Cqrs.Api.Entities.Common
{
    public abstract class RootEntity<TKey> : IRootEntity where TKey : struct, IEquatable<TKey>
    {
        [Key]
        public TKey Id { get; }
        public DateTime CreatedDate { get; } = DateTime.Now;
        public DateTime? ModifiedDate { get; init; }
        public bool Deleted { get; init; } = false;
        public bool Disabled { get; init; } = false;
    }

    public interface IRootEntity
    {
    }
}
