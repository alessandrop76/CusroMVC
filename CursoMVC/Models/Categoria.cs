using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição da Categoria é obrigatório")]
        public string Descricao { get; set; }

       // public List<Produto> Produtos { get; set; }
    }
}
