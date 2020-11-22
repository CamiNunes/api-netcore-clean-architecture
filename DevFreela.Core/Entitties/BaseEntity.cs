namespace DevFreela.Core.Entitties
{
    public abstract class BaseEntity
    {
        protected BaseEntity() { }

        public int Id { get; private set; }
    }
}
