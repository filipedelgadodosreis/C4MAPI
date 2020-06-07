namespace C4M.Domain.Entities
{
    public abstract class BaseEntity
    {
        public virtual long Id { get; internal protected set; }
    }
}
