using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Model
{
    public class ResponsableBibliotheque : Utilisateur
    {
        [Key]
        public int IdRespBiblio {  get; set; }

        [Display(Name = "Batiment du responsable bibliothecaire")]
        [MaxLength(80, ErrorMessage = "Taille max 80"), Required(ErrorMessage = "*")]
        public string batiment { get; set; }
    }
}