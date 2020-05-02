using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_aspnet_core.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        [Display(Name ="Código")]
        public int Id { get; set; }

        [Display(Name ="Descrição")]
        [Required(ErrorMessage ="Campo Obrigatório")]
        public string Descricao { get; set; }

        public ICollection<Despesa> Despesas { get; set; }
    }
}
