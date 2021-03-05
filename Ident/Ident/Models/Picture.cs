using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ident.Models
{
    public class Picture
    { 
        [Key]
        public int IdentityID { get; set; }
        [Required][Display(Name ="Nombre Completo")][StringLength(30,MinimumLength =5)]
        public string Name { get; set; }
        [Required]
        public string Photo { get; set; }
        [Required]
        public string Sex { get; set; }
        [EmailAddress][Display(Name="Ingrese correo valido")]
        public string email { get; set; }
        [Display(Name ="Cumpleaños")]
        public DateTime birthdate { get; set; }


    }
}
