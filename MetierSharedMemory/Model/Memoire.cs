using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Model
{
    public class Memoire
    {
        [Key]
        public int IdMemoire { get; set; }

        [Display(Name = "Sujet de mémoire")]
        [MaxLength(80, ErrorMessage = "Taille max 300"), Required(ErrorMessage = "*")]
        public string Sujet { get; set; }

        public string FileName { get; set; }

        [Display(Name = "Nom complet de l'auteur")]
        [MaxLength(80, ErrorMessage = "Taille max 150"), Required(ErrorMessage = "*")]
        public string Auteur { get; set; }

        [Required(ErrorMessage ="*")]
        public int Annee { get; set; }

        public int? IdEncadreur { get; set; }

        [ForeignKey("IdEncadreur")]
        public Encadreur Encadreur { get; set; }

        public int? IdMembreJury { get; set; }

        [ForeignKey("IdMembreJury")]
        public MembreJury MembreJury { get; set; }


        public string Note { get; set; }


        public string Deliberation { get; set; }


        public string Niveau { get; set; }

        [Display(Name = "Specialite de l'etudiant")]
        [MaxLength(80, ErrorMessage = "Taille max 80"), Required(ErrorMessage = "*")]
        public string Specialite { get; set; }
    }
}