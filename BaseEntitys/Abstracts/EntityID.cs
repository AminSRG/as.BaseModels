namespace AS.BaseModels.BaseEntitys.Abstracts
{
    public abstract class EntityID : BaseEntity, Interfaces.IEntityID
    {
        public Guid ID { get; set; } = Guid.NewGuid();
    }
}
