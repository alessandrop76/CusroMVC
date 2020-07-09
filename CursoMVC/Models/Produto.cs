using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição" )]
        [Required(ErrorMessage ="O campo descrição do Produto é obrigatório")]
        public string Descricao { get; set; }
        [Range(1,1000, ErrorMessage = "Não está permitido criar um produto com Quantidade 0 no Estoque")]
        //[Required(ErrorMessage = "Não está permitido criar um produto com Quantidade 0 no Estoque")]
        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
