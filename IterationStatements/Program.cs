namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void Print1000s()
        {
            for (var i = 1000; i >=1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time


        public static void PrintThrees()
        {
            for(var i=3; i <=999; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void TwoIntsEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("They're equal");
            }
            else
            {
                Console.WriteLine("They aren't equal");
            }
        }
        
        //Write a method to check whether a given number is even or odd

        public static void OddVsEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }
        }
        
        //Write a method to check whether a given number is positive or negative

        public static void PositiveOrNegative(int num)
        {
            if(num > 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is negative");
            }
            else
            {
                Console.WriteLine($"{num} is neither positive nor negative");
            }
              
        }

        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void CanVote()
        {

            /*if (number >= 18)
            {
                Console.WriteLine("Yay, you can vote");
            }
            else
            {
                Console.WriteLine("Sorry, see you next time");
            }*/

            bool userAge;
            int result;

            do
            {
                Console.WriteLine("Please enter your age");

                userAge = int.TryParse(Console.ReadLine(), out result);
            } while (!userAge);

            if (result <18)
            {
                Console.WriteLine("Sorry, see you next time");
            }
            else
            {
                Console.WriteLine("Yay, you can vote!");
            }


        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void IntRange()
        {
            bool userResponse;
            int result;

            do
            {
                Console.WriteLine("Please enter a whole number");

                userResponse = int.TryParse(Console.ReadLine(), out result);
            } while (!userResponse);

            Console.WriteLine((result >= -10 && result <= 10) ? $"{result} is between 10 & -10" : $" {result} is not Between 10 & -10");
        }

        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultTable()
        {
            bool cont;
            int userInput;

            do
            {
                Console.WriteLine("Please enter an integer");

                cont = int.TryParse(Console.ReadLine(), out userInput);
            } while (!cont);

            for (var x = 0; x <= 12; x++)
            {
                Console.WriteLine($"{x} x {userInput} = {x * userInput}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //Print1000s();
            //PrintThrees();
            //TwoIntsEqual(2, 2);
            //TwoIntsEqual(3, 5);
            //OddVsEven(10);
            //OddVsEven(13);

            //PositiveOrNegative(2);
            //PositiveOrNegative(-45);
            //PositiveOrNegative(0);

            //CanVote();
            //CanVote();

            //IntRange();

            MultTable();

        }
    }
}
