namespace Domain.Entities;

public class Entity<TId>
{
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }

    public Entity()
    {
        CreatedDate = DateTime.UtcNow;
    }

    public Entity(TId id)
    {
        Id = id;
        CreatedDate = DateTime.UtcNow;
    }
}

