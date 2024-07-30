using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Model
{
    public class Personne
    {
        [Key]
        public int IdPersonne { get; set; }

        [Display(Name ="Nom")]
        [MaxLength(80, ErrorMessage ="Taille max 80"),Required(ErrorMessage ="*")]
        public string Nom { get; set; }

        [Display(Name = "Prénom")]
        [MaxLength(80, ErrorMessage = "Taille max 80"), Required(ErrorMessage = "*")]
        public string Prenom { get; set; }

    }
}