internal class Program
{
    public class Pessoa
    {
        string? _nome;
        string? _sobrenome;

        public Pessoa() { }

        public void DefinirNome(string s)
        {
            this._nome = s;
        }

        public string RetornarNome()
        {
            return this._nome;
        }

        public void DefinirSobrenome(string s)
        {
            this._sobrenome = s;
        }

        public string RetornarSobrenome()
        {
            return this._sobrenome;
        }

        public string RetornarNomeCompleto()
        {
            return RetornarNome() + " " + RetornarSobrenome();
            //return this._nome + this._sobrenome;
        }

    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Pessoa p = new Pessoa();
        Pessoa p2 = new Pessoa();

        Console.WriteLine("Informe seu nome: ");
        p.DefinirNome(Console.ReadLine());

        Console.WriteLine("Informe seu sobrenome: ");
        p.DefinirSobrenome(Console.ReadLine());

        Console.WriteLine("Seja bem vindo a orientacao a objetos, " + p.RetornarNome());
        Console.WriteLine("Seja bem vindo a orientacao a objetos, " + p.RetornarSobrenome());

        Console.WriteLine(p.RetornarNomeCompleto());

        Console.WriteLine(p.GetType().ToString());
    }

}

