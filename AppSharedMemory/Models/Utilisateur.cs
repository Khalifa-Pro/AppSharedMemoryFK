using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSharedMemory.Models
{
    public class Utilisateur
    {
        public int id { get; set; }

        [Display(Name = "Nom de l'utilisateur")]
        [MaxLength(80, ErrorMessage = "Taille max 80"), Required(ErrorMessage = "*")]
        public string nom { get; set; }

        [Display(Name = "Prénom de l'utilisateur")]
        [MaxLength(80, ErrorMessage = "Taille max 80"), Required(ErrorMessage = "*")]
        public string prenom { get; set; }

        [Display(Name = "Age de l'utilisateur")]
        [Required(ErrorMessage = "*")]
        public int age { get; set; }
    }
}
