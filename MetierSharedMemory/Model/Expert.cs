using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Model
{
    public class Expert : Utilisateur
    {
        [Key] 
        public int IdExpert { get; set; }

        [Display(Name = "Specialite de l'expert")]
        [MaxLength(80, ErrorMessage = "Taille max 80"), Required(ErrorMessage = "*")]
        public string SpecialiteExpert { get; set; }
    }
}