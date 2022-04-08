
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVCGP.Models
{
    public class Cotizar
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Producto")]
        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }

        [Display(Name = "Plazos")]
        public int SemanasId { get; set; }
        [ForeignKey("SemanasId")]
        public virtual Semanas Semanas { get; set; }

    }
}

