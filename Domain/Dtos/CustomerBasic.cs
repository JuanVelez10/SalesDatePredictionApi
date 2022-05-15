using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class CustomerBasic
    {
        [Key]
        [Required]
        public int Custid { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Companyname { get; set; } = null!;

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime LastOrderDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime NextOrderDate { get; set; }

    }
}
