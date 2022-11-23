using System.ComponentModel.DataAnnotations;

namespace HospitalApi.Models
{
    public class CostCenter
    {
        [Key]
        public int codCentroCusto { get; set; }

        [StringLength(50)]
        public string nomeCentroCusto { get; set; }
    }
}
