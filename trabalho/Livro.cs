// Classe Livro com atributos, construtores, métodos e sobrecarga de métodos
    public class Livro
    {
        public string Titulo { get; private set; }
        public Autor Autor { get; private set; }
        public double Preco { get; private set; }

        public Livro(string titulo, Autor autor)
        {
            Titulo = titulo;
            Autor = autor;
            Preco = 0.0; // Preço inicial padrão
        }

        public Livro(string titulo, Autor autor, double preco)
        {
            Titulo = titulo;
            Autor = autor;
            Preco = preco;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Livro: {Titulo}");
            Autor.MostrarInfo();
            Console.WriteLine($"Preço: R${Preco:F2}");
        }

        public void AplicarDesconto(double porcentagemDesconto)
        {
            Preco -= Preco * (porcentagemDesconto / 100);
        }

        public void AplicarDesconto(int valorDesconto)
        {
            Preco -= valorDesconto;
        }
    }
