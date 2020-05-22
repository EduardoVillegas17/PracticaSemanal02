using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PractSem2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public int CantidadProductos { get; set; }
        public int Total { get; set; }
        public string Status { get; set; }
        public int IdProducto { get; set; }
        [ForeignKey("IdProducto")]
        public Product Product { get; set; }
    }
}