using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLivrariaCore.Models
{
    public class HomeReturn
    {
        public Livro livroUltimo { get; set; }
        public Livro livroBarato { get; set; }
        public Livro livroNovo { get; set; }
    }
}
