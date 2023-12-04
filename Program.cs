internal class Program
{
    private static void Main(string[] args)
    {
        bool flag = true;
        do
        {
            Console.Clear();
            Console.WriteLine("----------- MENÚ --------------");
            Console.WriteLine("1. Verificar Par de números Amistosos");
            Console.WriteLine("2. Mostrar Par de números Amistosos entre 1000 y 1500");
            Console.WriteLine("3. Salir del Programa");
            Console.WriteLine("-------------------------------------------");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    System.Console.Write("Digite primer número: ");
                    int number1 = int.Parse(Console.ReadLine());
                    System.Console.Write("Digite segundo número: ");
                    int number2 = int.Parse(Console.ReadLine());
                    List<int> divisores1 = new List<int>();
                    List<int> divisores2 = new List<int>();
                    for (int i = 1; i < number1; i++)
                    {
                        if (number1 % i == 0)
                        {
                            divisores1.Add(i);
                        }
                    }
                    for (int i = 1; i < number2; i++)
                    {
                        if (number2 % i == 0)
                        {
                            divisores2.Add(i);
                        }
                    }
                    if (divisores1.Sum() == number2 && divisores2.Sum() == number1)
                    {
                        System.Console.WriteLine("{0} y {1} Son números amistosos :D", number1, number2);
                    }
                    else
                    {
                        System.Console.WriteLine("{0} y {1} No son números amistosos :(", number1, number2);
                    }
                    break;

                case "2":
                Console.Clear();
                    for (int i = 1000; i <= 1500; i++)
                    {
                        int result = SumaDivisores(i);
                        if (result > i && SumaDivisores(result) == i)
                        {
                            System.Console.WriteLine("El par amistoso es: {0} Y {1}", i,result);
                            break;
                        }
                    }
                    static int SumaDivisores(int numero)
                    {
                        int suma = 1;
                        for (int i = 2; i <= Math.Sqrt(numero); i++)
                        {
                            if (numero % i == 0)
                            {
                                suma += i;
                                if (i != numero / i)
                                {
                                    suma += numero / i;
                                }
                            }
                        }
                        return suma;
                    }
                    break;
                case "3":
                System.Console.WriteLine("Adioos");
                flag = false;
                break;
            }
            System.Console.WriteLine("Toque una tecla para continuar");
            Console.ReadLine();
        } while (flag);
    }
}