using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrecosApiExamen.Models
{
    public class DetallesPedido
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Pedido))]
        public int PedidoId { get; set; }

        public Pedido Pedido { get; set; }

        [ForeignKey(nameof(Producto))]
        public int ProductoId { get; set; }

        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
