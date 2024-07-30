using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Model
{
    public class MembreJury : Personne
    {
        [Display(Name = "Spécialité du membre de jury")]
        [MaxLength(80, ErrorMessage = "Taille max 80"), Required(ErrorMessage = "*")]
        public string SpecialiteJury { get; set; }
    }
}