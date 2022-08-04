using System;


namespace SoloLearn
{

    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite animal");
            string userFavAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band");
            string userFavBand = Console.ReadLine();

            Console.WriteLine("What is your favorite color");
            string userFavColor = Console.ReadLine();


            Console.WriteLine($"There was a person named {userName}. Their favorite animal is {userFavAnimal}.");
            Console.WriteLine($"Their favorite color is {userFavColor}. And their favorite band is {userFavBand}.");
            Console.WriteLine($"{userName} loved {userFavAnimal}s, the color {userFavColor}, and the band {userFavBand}");


            Console.WriteLine("Give me a number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);

            Console.WriteLine($"The sum is {sum}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to Multiply the first one by");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is {product}");
          }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
	