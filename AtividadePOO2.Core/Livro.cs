using System.Text.RegularExpressions;

namespace AtividadePOO2.Core;

public class Livro
{
    public Livro(string titulo, string categoria, string autor, string genero,  int NumeroDePaginas, int Preco)
    {
        
        ValidarTitulo(titulo);
        ValidarCategoria(categoria);
        ValidarAutor(autor);
        ValidarGenero(genero);

    }
    
    public string Titulo { get; private set; } 
    public string Categoria { get; private set; } 
    public string Autor { get; private set; } 
    public string Genero { get; private set; }
    
    public int Id { get; private set; }
    public int NumeroDePaginas { get; private set; } 
    public int Preco { get; private set; }

    private void ValidarTitulo(string titulo)
    {
        if (string.IsNullOrWhiteSpace(titulo))
            throw new Exception("O Titulo não pode ser nulo ou vazio");
        Titulo = titulo;
    }
    
    private void ValidarCategoria(string categoria)
    {
        if (string.IsNullOrWhiteSpace(categoria))
            throw new Exception("a Categoria não pode ser nulo ou vazio");
        Categoria = categoria;
    }
    
    private void ValidarAutor(string autor)
    {
        if (string.IsNullOrWhiteSpace(autor))
            throw new Exception("O Autor não pode ser nulo ou vazio");
        Autor = autor;
    }
    
    private void ValidarGenero(string genero)
    {
        if (string.IsNullOrWhiteSpace(genero))
            throw new Exception("O Genero não pode ser nulo ou vazio");
        Genero = genero;
    }
}