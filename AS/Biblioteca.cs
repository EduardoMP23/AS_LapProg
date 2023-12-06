public class Biblioteca
{
    /*Criando espaços para armazena os livros*/
    string? Estante1 = null;
    string? Estante2 = null;

    /*Método para adicionar os livro aos espaços*/
    public void AdicionarItem(string titulo)
    {
        if (Estante1 == null){
            Estante1 = titulo;
        }
        
        else if(Estante2 == null){
            Estante2 = titulo;
        }
    
    }
    /*Método para remover os livro dos espaços*/
    public void RemoverItem()
    {
        if (Estante1 != null){
            Estante1 = null;
        }
        else if(Estante2 != null){
            Estante2 = null;
        }
    }

    /*Método para ver os espaços disponiveis*/
    public void VerEstantes()
    {
        Console.WriteLine($"\nEstante1: {Estante1}\nEstante2: {Estante2}\n");

    }

}