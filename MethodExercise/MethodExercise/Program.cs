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
            Console.WriteLine($"Their favorite color is {userFavColor}.");
            Console.WriteLine($"And their favorite band is {userFavBand}.");
            Console.WriteLine($"{userName}'s favorite animal was {userFavAnimal}, and their favorite band was {userFavBand} and favorite color was {userFavColor}.")}

            Console.WriteLine("Give me a number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = sum(num1, num2);

            Console.WriteLine($"The sum is {sum}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to Multiply the first one by");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num3, num4);
            Console.WriteLine($"The product is {product}");
          }

    public static int Sum(params int[] list)
    {
        int sum = 0;

        for (int i = 0; i < list.Length; i++)
        {
            sum = sum + list[i];
        }

        return sum;
    }

    public static int Multiply(num3, num4)
    {
        return num3 * num4;
    }
}
}
	