using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Model
{
    public class Utilisateur : Personne
    {
        [Key]
        public int IdUtilisateur { get; set; }

        [Display(Name = "Votre matricule")]
        [MaxLength(80, ErrorMessage = "Taille max 80"), Required(ErrorMessage = "*")]
        public string Matricule { get; set; }

        [Display(Name = "Votre numéro de telephone")]
        [MaxLength(80, ErrorMessage = "Taille max 50"), Required(ErrorMessage = "*")]
        public string Telephone { get; set; }

        [Display(Name = "Votre adresse email: exemple@gamail.com")]
        [MaxLength(80, ErrorMessage = "Taille max 300"), Required(ErrorMessage = "*")]
        public string Email { get; set; }

        [Required(ErrorMessage ="*")]
        public string MotDePasse { get; set; }

        [Required(ErrorMessage = "*")]
        public string Statut { get; set; }

    }
}