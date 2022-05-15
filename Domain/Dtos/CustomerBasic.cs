using System.ComponentModel.DataAnnotations;


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
        public DateTime NextPredictedOrderDate { get; set; }

    }
}
