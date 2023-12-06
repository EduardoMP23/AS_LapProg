public class Livro : ItemBiblioteca
{
    string? assunto;
    /*Definindo a descrição do livro(tematica)*/
    public Livro(int id, string titulo) : base(id, titulo)
    {
        Console.WriteLine("\nQual o tema do livro ?");
        assunto = Console.ReadLine();
        DescriçãoInterna += assunto;
    }
    /*Método que apresenta o livro*/
    public void ExibirDescriçãoInterna(int id, string titulo){
        Console.WriteLine($"O livro {id}-{titulo} {DescriçãoInterna}");
    }
}