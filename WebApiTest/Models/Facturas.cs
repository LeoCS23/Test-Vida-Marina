using Microsoft.AspNetCore.Mvc;

namespace WebApiTest.Models
{
    public class Facturas
    {
        public int Id { get; set; }
        public required string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public Boolean Activo { get; set; }
    }
}
