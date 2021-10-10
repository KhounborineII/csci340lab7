using System;
using System.ComponentModel.DataAnnotations;

namespace RPFGOAccount.Models
{
    public class Character
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Level { get; set; }
        public int ATK { get; set; }
        public int HP { get; set; }
    }
}