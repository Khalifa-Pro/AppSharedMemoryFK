using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSharedMemory.Models
{
    public class Td_erreur
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Date de l'erreur")]
        public DateTime DateErreur { get; set; }


        [Display(Name = "Description de l'erreur")]
        public string DescriptionErreur { get; set; }
        [Display(Name = "TitreErreur")]
        public string TitreErreur { get; set; }
    }
}
