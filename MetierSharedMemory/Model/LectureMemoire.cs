using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Model
{
    public class LectureMemoire
    {
        [Key]
        public int IdLectureMemoire { get; set; }
        public int? IdLecteur { get; set; }

        [ForeignKey("IdLecteur")]
        public Lecteur Lecteur { get; set; }
    }
}