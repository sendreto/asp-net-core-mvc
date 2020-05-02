using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_aspnet_core.Models
{
    [Table("Despesas")]
    public class Despesa
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Descricao { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime Data { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public double Valor { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }
    }
}
