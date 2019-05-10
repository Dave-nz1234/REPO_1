using System;

namespace Draft
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                {1, 2, },
                {3, 4, },
                {5, 6, }

            };

            Console.WriteLine(numberGrid[2, 0]);


            Console.WriteLine(GetPow(3, 3));




            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };


            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);

            }




            string secretWord = "Catatonic";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;
            bool firstGuess = false;

            Console.WriteLine("Guess the secret word: ");
            guess = Console.ReadLine();
            guessCount++;
            if (guess == secretWord)
            {
                Console.WriteLine("You win!");
                firstGuess = true;
            }
            else

                do
                    if (guessCount < guessLimit)
                    {
                        Console.WriteLine("Wrong answer, try again: ");
                        guess = Console.ReadLine();
                        guessCount++;
                    }
                    else
                    {
                        outOfGuesses = true;
                    } while (guess != secretWord && !outOfGuesses);

            if (guess != secretWord && outOfGuesses)
            {
                Console.WriteLine("You're out of guesses mate");
            }
            else if (!firstGuess)
            {
                Console.WriteLine("You're a winner!");
            }




            int index = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);






            Console.WriteLine("enter day number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetDay(num));



            Console.WriteLine(GetMax(100, 101, 13));

            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short Male");
                ;
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are a tall female");
            }
            else
            {
                Console.WriteLine("You are not tall and not male.");
            }


            Console.Write("Enter your name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name + ", how old are you?: ");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name + ", you are " + age + " years old. And guess what?");

            Console.ReadLine();

            Console.WriteLine("You are " + (100 - age) + " years away from being a century old");

            Console.WriteLine();

            Insult(name);

            Console.WriteLine("You are allowed to date girls no younger than " + DatingAge(age) + " years old.");

            string color, pluralNoun, celebrity;

            Console.WriteLine("Enter a color: ");
            color = Console.ReadLine();

            Console.WriteLine("What are your favourite flowers?: ");
            pluralNoun = Console.ReadLine();

            Console.WriteLine("Who is your favourite celebrity?: ");
            celebrity = Console.ReadLine();



            Console.WriteLine("Roses are " + color + ".");

            Console.WriteLine("Violets are " + color + ".");

            Console.WriteLine("I love " + celebrity + ".");

            Console.WriteLine("And you are " + (1000 - age) + " years away from being 1000 years old.");


            Console.ReadLine();
        }
        static void Insult(string name)
        {
            Console.WriteLine("Fuck you " + name);
        }
        static int DatingAge(int age)
        {

            int result = (age / 2) + 7;
            return result;
        }
        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;

            }
            return dayName;
        }
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }


            return result;






        }



    }
}
