namespace Exercício3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número");
            string numero1 = Console.ReadLine();

            Console.WriteLine("Escreva mais um número");
            string numero2 = Console.ReadLine();

            double num1 = Convert.ToDouble(numero1);
            double num2 = Convert.ToDouble(numero2);


            double soma = num1 * num2;
            Console.WriteLine("A soma dos números é: " + soma);
        }
    }
}
