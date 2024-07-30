using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Model
{
    public class Commentaire
    {
        [Key]
        public int IdCommentaire { get; set; }

        [Display(Name = "Votre commentaire ...")]
        [MaxLength(80, ErrorMessage = "Taille max 500"), Required(ErrorMessage = "*")]
        public string Text { get; set; }

        public int? IdLecteur { get; set; }

        [ForeignKey("IdLecteur")]
        public Lecteur Lecteur { get; set; }
    }
}