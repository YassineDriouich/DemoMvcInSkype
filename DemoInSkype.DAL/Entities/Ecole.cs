using System;
using System.ComponentModel.DataAnnotations;

namespace DemoInSkype.DAL.Entities
{
    public class Ecole
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Adresse { get; set; }
        [Required]
        public DateTime DateCreation { get; set; }
    }
}
