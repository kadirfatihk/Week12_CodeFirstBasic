using System.ComponentModel.DataAnnotations;

namespace Week12_CodeFirstBasic.Entities
{
    public class GameEntity : BaseEntity
    {
        public string name { get; set; }
        public string platform { get; set; }


        [Range(0,10)]
        public decimal rating { get; set; }
    }
}
