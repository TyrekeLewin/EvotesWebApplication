namespace EvotesWebApplication.Data
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime EnteredDate { get; set; }
    }
}
