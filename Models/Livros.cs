using System;
using System.Collections;

namespace Biblioteca.Models
{
    public class Livros
    {
        public int Id;
        public string Titulo;
        public string Autor;

        public Livros(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        List<Livros> livraria = new List<Livros>();
    }


}