using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Model
{
    public class Encadreur: Personne
    {
        [Display(Name = "Spécialité de l'encadreur")]
        [MaxLength(80, ErrorMessage = "Taille max 80"), Required(ErrorMessage = "*")]
        public string SpecialiteEncadreur { get; set; }
    }
}