namespace AS.BaseModels.BaseEntitys.Abstracts
{
    public abstract class EntityID : BaseEntity, Interfaces.IEntityID
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
