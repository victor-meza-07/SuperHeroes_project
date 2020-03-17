using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Superhero.Models
{
    public class SuperheroModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string AlterEgo { get; set; }
        public string Primary_Ability { get; set; }
        public string Secondary_Ability { get; set; }
        public string Catch_Phrase { get; set; }
    }
}
