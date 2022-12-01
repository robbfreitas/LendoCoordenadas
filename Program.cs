namespace LendoCoordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lendo coordenadas de um plano cartesiano e informando o seu quadrante

            Console.Write("Informe o valor de X: ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de Y: ");
            double Y = double.Parse(Console.ReadLine());

            while (X != 0 && Y != 0)
            {

                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("Quadrante I");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("Quadrante II");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("Quadrante III");
                }
                else
                {
                    Console.WriteLine("Quadrante IV");
                }

                Console.Write("Informe o valor de X: ");
                X = int.Parse(Console.ReadLine());
                Console.Write("Informe o valor de Y: ");
                Y = int.Parse(Console.ReadLine());
            }

        }
    }
}