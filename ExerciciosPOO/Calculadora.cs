namespace ExerciciosEncapsulamento
{
    public class Calculadora
    {
        public double a { get; set; }
        public double b { get; set; }

        public void Somar()
        {
            Console.WriteLine($"Resultado: {a + b}");
        }

        public void Subtrair()
        {
            Console.WriteLine($"Resultado: {a - b}");
        }

        public void Multiplicar()
        {
            Console.WriteLine($"Resultado: {a * b}");
        }

        public static double aDivisao { get; set; }
        public static double bDivisao { get; set; }
        public static void Dividir(double a, double b)
        {
            aDivisao = a;
            bDivisao = b;
            Console.WriteLine($"Resultado: {aDivisao / bDivisao}");
        }
    }

}