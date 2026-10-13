namespace AtividadePOO2.Core;

public class Livro
{
    public string Titulo { get; private set; } 
    public string Categoria { get; private set; } 
    public string Autor { get; private set; } 
    public string Genero { get; private set; }
    public string CapaDoLivro { get; private set; }
    
    public int NumeroDePaginas { get; private set; } 
    public int Preco { get; private set; } 
}