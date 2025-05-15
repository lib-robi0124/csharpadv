namespace Exercise01.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract string Info();
    }
}
