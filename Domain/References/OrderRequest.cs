using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.References
{
    public class OrderRequest
    {
        [Required]
        public int? Custid { get; set; }
        [Required]
        public int Empid { get; set; }
        [Required]
        public int Shipperid { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Orderdate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Requireddate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime? Shippeddate { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Freight { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Shipname { get; set; } = null!;
        [Required]
        [DataType(DataType.Text)]
        public string Shipaddress { get; set; } = null!;
        [Required]
        [DataType(DataType.Text)]
        public string Shipcity { get; set; } = null!;
        [Required]
        [DataType(DataType.Text)]
        public string Shipcountry { get; set; } = null!;
        [Required]
        public int Productid { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Unitprice { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public short Qty { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Discount { get; set; }

    }
}
