namespace ExerciciosEncapsulamento
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Cidade { get; set; }

    public void Apresentar()
        {
            Console.WriteLine($"Dados \nNome: {Nome} \nIdade: {Idade} \nCidade: {Cidade} \n");
        }
    }
}