using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrecosApiExamen.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        [ForeignKey(nameof(Cliente))]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
