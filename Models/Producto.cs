using System.ComponentModel.DataAnnotations;

namespace CrecosApiExamen.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Costo { get; set; }
        public bool Estado { get; set; }
    }
}
