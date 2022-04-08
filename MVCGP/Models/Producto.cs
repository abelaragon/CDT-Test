using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCGP.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Clave del Producto")]
        public string KeyProduct { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [DisplayName("Nombre del Producto")]
        public string nombreProducto { get; set; }

        [Column(TypeName = "decimal (38,17)")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [DisplayName("Precio")]
        public decimal PrecioProducto { get; set; }
    }
}
