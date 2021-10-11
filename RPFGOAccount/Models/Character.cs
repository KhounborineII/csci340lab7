using System;
using System.ComponentModel.DataAnnotations;

namespace RPFGOAccount.Models
{
    public class Character
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        [Range(1,100)]
        public int Level { get; set; }
        [Range(1, 20000)]
        public int ATK { get; set; }
        [Range(1, 20000)]
        public int HP { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(15, MinimumLength = 3)]
        public string Class { get; set; }
    }
}