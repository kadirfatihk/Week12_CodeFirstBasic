namespace Week12_CodeFirstBasic.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = new DateTime();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool isDeleted { get; set; }
    }
}
