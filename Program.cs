using System.Reflection.Metadata.Ecma335;
using Biblioteca.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Livros> livros = new List<Livros>();
livros.Add(new Livros("Das Kapital", "Karl Marx"));
livros.Add(new Livros("Left and Right", "Noberto Bobbio"));
livros.Add(new Livros("State, Society and Goverment", "Noberto Bobbio"));
livros.Add(new Livros("1984", "George Orwell"));
app.MapGet("/", () =>
{
    foreach (var livro in livros)
    {
        Console.WriteLine($"Titulo: {livro.Titulo}| Autor: {livro.Autor}");
    }
});
app.Run();