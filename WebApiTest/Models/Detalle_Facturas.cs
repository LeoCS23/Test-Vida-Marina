namespace WebApiTest.Models
{
    public class Detalle_Facturas
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public required string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
