using System.ComponentModel.DataAnnotations;

namespace HospitalApi.Models
{
    public class Movement
    {
        [Key]
        public int codMovimentacao { get; set; }

        public int codInternacao { get; set; }

        public int codSequencia { get; set; }

        [StringLength(70)]
        public string nomePacienteMov { get; set; }

        public DateTime dataMovimentacao { get; set; }

        [StringLength(70)]
        public string motivo { get; set; }

        [StringLength(50)]
        public string localizacao { get; set; }

        [StringLength(30)]
        public string leitoMov { get; set; }

        [StringLength(30)]
        public string centroCustoMov { get; set; }

        [StringLength(50)]
        public string medicoMov { get; set; }

        [StringLength(6)]
        public string crmMov { get; set; }
    }
}
