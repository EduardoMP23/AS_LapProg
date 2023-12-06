/*Criação do modelo básico sobre os livros*/
public abstract class  ItemBiblioteca{

/* Atributos */
public string? Titulo;
public int ID;
protected string? DescriçãoInterna;
/* Construtor*/
    public ItemBiblioteca(int id, string titulo){
        ID = id;
        Titulo = titulo;
        DescriçãoInterna = "É sobre a temática de ";
    }
} 