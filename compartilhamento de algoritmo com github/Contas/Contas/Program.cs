namespace Contas
{
    public class Contas
    {
        public int Soma(int a, int b)
        {
            return a + b;
        }
        public int Subtracao(int a, int b)
        {
            return a - b;
        }

        public int Divisao(int a, int b)
        {
            return a / b;
        }
        public int Multiplicacao(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Contas contas = new Contas();

            Console.WriteLine("Digite o primeiro número inteiro da operação: ");
            String primeiro = Console.ReadLine();
            Console.WriteLine("Digite o segundo número inteiro da operação: ");
            String segundo = Console.ReadLine();


            int a = Convert.ToInt32(primeiro);
            int b = Convert.ToInt32(segundo);

            var soma = contas.Soma(a, b);
            var subtracao = contas.Subtracao(a, b);
            var divisao = contas.Divisao(a, b);
            var multiplicacao = contas.Multiplicacao(a, b);

            Console.WriteLine("Operação entre " + a + " e " + b);
            Console.WriteLine("Soma = " + soma);
            Console.WriteLine("Subtração = " + subtracao);
            Console.WriteLine("Divisao = " + divisao);
            Console.WriteLine("Multiplicação = " + multiplicacao);
        }
    }
}