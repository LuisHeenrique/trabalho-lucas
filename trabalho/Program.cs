using System;
class Program
    {
        static void Main(string[] args)
        {
            // Criação de um autor
            Autor autor = new Autor("Machado de Assis", "Brasileiro");

            // Criação de livros com diferentes construtores
            Livro livro1 = new Livro("Dom Casmurro", autor);
            Livro livro2 = new Livro("Memórias Póstumas de Brás Cubas", autor, 45.90);

            // Exibindo informações dos livros
            Console.WriteLine("Informações do Livro 1:");
            livro1.MostrarInfo();

            Console.WriteLine("\nInformações do Livro 2:");
            livro2.MostrarInfo();

            // Aplicando descontos utilizando polimorfismo
            Console.WriteLine("\nAplicando 10% de desconto no Livro 2:");
            livro2.AplicarDesconto(10);
            livro2.MostrarInfo();

            Console.WriteLine("\nAplicando desconto fixo de R$5,00 no Livro 2:");
            livro2.AplicarDesconto(5);
            livro2.MostrarInfo();
        }
    }
