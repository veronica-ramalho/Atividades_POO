namespace ExerciciosEncapsulamento
{
    public class Veiculo
    {
        private int velocidade;

        public int Velocidade
        {
            get
            {
                return velocidade;
            }
            set
            {
                if (velocidade >= 0 && velocidade <= 200)
                {
                    velocidade = value;
                    Console.WriteLine($"Velocidadde: {Velocidade}");
                }
                else
                    Console.WriteLine("Valor inválido");
            }
        }
    }
}