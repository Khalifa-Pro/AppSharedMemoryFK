using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Model
{
    public class Lecteur : Utilisateur
    {
        [Key]
        public int IdLecteur { get; set; }
    }
}