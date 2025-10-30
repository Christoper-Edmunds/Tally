namespace Tally.Data.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            SoftDeleted = false;
            CreatedDate = DateTime.UtcNow;
            LastModifiedDate = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool SoftDeleted { get; set; }
        public bool ReadyForHardDeletion => SoftDeleted && LastModifiedDate < DateTime.UtcNow.AddDays(-7); // consider adding a global config for hard delete delay

    }
}
