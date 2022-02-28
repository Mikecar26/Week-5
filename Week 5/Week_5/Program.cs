


namespace Week_5
{
    class program
    {
        static int Main()
        {

            Divisible3();
            Sum();
            Factorial();
            RandomGuess();
            Max();


            return 0;

        }



        static void Divisible3()
        {
            int counter = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        static void Sum()
        {
            int sum = 0;
            string input = "";
            Console.WriteLine("Enter a list of numbers, then type \"ok\" to calculate the sum.");
            do 
            {
                input = Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }
                sum += Int32.Parse(input); 
               
            } while (true);

            Console.WriteLine(sum);
        }
        static void Factorial()
        {
            int factorial = 1;
            string input;
            Console.WriteLine("Enter a number to calculate it's factorial.");
            input = Console.ReadLine();

            for (int i = 1; i < Int32.Parse(input) + 1; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
        static void RandomGuess()
        {
            string guess;
            int randomGuess;
            Random random = new Random();
            randomGuess = random.Next(9) + 1;

            Console.WriteLine("Guess a random number between 1 to 10");

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine(randomGuess);
                guess = Console.ReadLine();

                if (Int32.Parse(guess) != randomGuess)
                {
                    Console.WriteLine("Try again!");
                    continue;
                }
                else
                {
                    Console.WriteLine("You Won!");
                    break;
                }

            }
        }
        static void Max()
        {
            string input;
            int max = 0;
            Console.WriteLine("Enter a string of numbers (seperated by a comma), to find the max number in list.");
            input = Console.ReadLine();
            foreach (string s in input.Split(new char[] { ',' }))
            {
                if (max < Int32.Parse(s))
                    max = Int32.Parse(s);

            }
            Console.WriteLine(max);
        }

    }
}
