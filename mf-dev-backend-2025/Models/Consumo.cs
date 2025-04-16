using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatorio informar a descricao")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a quilometragem")]
        public int Km { get; set; }

        [Display(Name = "Tipo de Combustivel")]
        public TipoCombustivel Tipo { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o veiculo")]
        [Display(Name = "Veiculo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
}
