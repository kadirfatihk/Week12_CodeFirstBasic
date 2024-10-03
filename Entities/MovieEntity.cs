namespace Week12_CodeFirstBasic.Entities
{
    public class MovieEntity : BaseEntity
    {
        public string title { get; set; }
        public string genre { get; set; }
        public int releaseYear { get; set; }
    }
}
