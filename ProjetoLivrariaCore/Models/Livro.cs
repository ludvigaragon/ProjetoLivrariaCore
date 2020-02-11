using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjetoLivrariaCore.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        [Required(ErrorMessage = "O campo 'ISBN' é obrigatório.")]
        public double ISBN { get; set; }
        [Required(ErrorMessage = "O campo 'Autor' é obrigatório.")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "O campo 'Nome' é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo 'Preço' é obrigatório.")]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:C}")]
        public decimal Preco { get; set; }
        [Required(ErrorMessage = "O campo 'Data de Publcação' é obrigatório.")]
        [Display(Name = "Data de Publicação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataPublicacao { get; set; }
        public string PathCapaLivro { get; set; }
        [Display(Name = "Capa do Livro")]
        [NotMapped]
        public IFormFile CapaLivro { get; set; }
    }

}
