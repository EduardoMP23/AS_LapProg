/*Criação do livros e da biblioteca*/
Livro l1 = new Livro(01, "star wars");
Livro l2 = new Livro(02, "it a coisa");
Biblioteca b1 = new Biblioteca();

/*Adicionando os livro*/
b1.AdicionarItem(l1.Titulo);
b1.AdicionarItem(l2.Titulo);

/*Vizualizando os livros*/
b1.VerEstantes();

/*Remoção de um livro*/
b1.RemoverItem();

/*Vizualização após remoçaõ*/
b1.VerEstantes();

/*Descrição dos livros*/
l1.ExibirDescriçãoInterna(l1.ID,l1.Titulo);
l2.ExibirDescriçãoInterna(l2.ID,l2.Titulo);