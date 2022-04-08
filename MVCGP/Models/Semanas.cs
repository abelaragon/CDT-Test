using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCGP.Models
{
    public class Semanas
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Clave")]
        public string KeySemana { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [DisplayName("Plazo en semana(s)")]
        public int Plazoss { get; set; }

        [Column(TypeName = "decimal (38,17)")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [DisplayName("Tasa puntual")]
        public decimal TasaP { get; set; }

        [Column(TypeName = "decimal (38,17)")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [DisplayName("Tasa normal")]
        public decimal TasaN { get; set; }

    }
}
