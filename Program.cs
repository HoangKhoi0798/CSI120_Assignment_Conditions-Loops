namespace CSI120_Assignment_Conditions_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hoang Khoi Gia Nguyen
            // CSI 120 - Computer Programming 1
            // Assignment - Conditions and Loops
            Menu();
        }// Main

        public static void Problem1()
        {
            Console.Write("Enter a number: "); // Input
            string userInput = Console.ReadLine();
            int userNum = int.Parse(userInput); // Parsing

            if (userNum < 0)// Condition for printing
            {
                Console.WriteLine("Negative");
            }
            else if (userNum == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Positive");
            }
        } // End of P1

        public static void Problem2()
        { // Number input
            Console.Write("Enter first number: ");
            string userInput = Console.ReadLine();
            decimal userNum1 = decimal.Parse(userInput);

            Console.Write("Enter second number: ");
            string userInput2 = Console.ReadLine();
            decimal userNum2 = decimal.Parse(userInput2);

            Console.Write("Enter third number: ");
            string userInput3 = Console.ReadLine();
            decimal userNum3 = decimal.Parse(userInput3);

            if (userNum1 > userNum2 && userNum1 > userNum3) // Conditions for each print
            {
                Console.WriteLine($"Largest number is: {userNum1}");
            }
            else if (userNum2 > userNum1 && userNum2 > userNum3)
            {
                Console.WriteLine($"Largest number is: {userNum2}");
            }
            else
            {
                Console.WriteLine($"Largest number is: {userNum3}");
            }
        }// End of P2


        public static void Problem3()
        {
            Console.Write("Enter an alphabet letter: "); // Letter input
            string userInput = Console.ReadLine();
            string userCheck = userInput.ToLower(); // Put input into lowercase for fewer conditions

            
                if (userInput.Length == 1 && userCheck == "a" || userCheck == "e" || userCheck == "i" || userCheck == "o" || userCheck == "u") // Condition to make sure it is a single letter and match the vowels
                {
                    Console.WriteLine("Vowel");
                }
                else
                {
                    Console.WriteLine("Consonant");
                }
            
        }// End of P3

        public static void Problem4()
        {
            Console.Write("Enter a number: "); // Input
            string userInput = Console.ReadLine();
            decimal userNum = decimal.Parse(userInput);
            int userCount = 1;
            

            while (userCount <= 10) // Condition setup to loop out the table
            {
                decimal userResult = userNum * userCount; // Operation for multiplication
                Console.WriteLine($"{userNum} * {userCount} = {userResult}");                
                userCount++;// Up the count for next operation
            }
        }// End of P4

        public static void Problem5()
        {
            Console.Write("Enter a number: ");// Input
            string userInput = Console.ReadLine();
            decimal userNum = decimal.Parse(userInput);
            int userCount = 0;

            for (int i = 1 ; i <= userNum; i++)// Set loop to check for prime
            {
                if (userNum % i == 0)
                {
                    userCount++;
                }

            }
            if (userCount == 2)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }

        }// End of P5

        public static void Problem6()
        {
            int userCount = 1;
            while (userCount <= 100)// Loop condition
            {
                if (userCount % 3 == 0 && userCount % 5 == 0)// Set up condition for words
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (userCount % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (userCount % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine($"{userCount}");
                }
                userCount++;// Loop times
            }


        }//End of P6

        public static void Menu()
        {
            Console.WriteLine("1 - Conditional Questions");
            Console.WriteLine("2 - Loop Questions");
            Console.WriteLine("3 - Exit");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("1 - Positive, Negative, or Zero");
                Console.WriteLine("2 - Largest of Three");
                Console.WriteLine("3 - Check for a vowel");
                Console.WriteLine("Press any other key to go back to the menu");
                string userResponse = Console.ReadLine();
                if (userInput == "1")
                {
                    Problem1();
                }
                else if (userInput == "2")
                {
                    Problem2();
                }
                else if (userInput == "3")
                {
                    Problem3();
                }
                else
                {
                    Menu();
                }

            }
            else if (userInput == "2")
            {
                Console.WriteLine("1 - Multiplication Table");
                Console.WriteLine("2 - Check for Prime");
                Console.WriteLine("3 - FizzBuzz");
                Console.WriteLine("Press any other key to go back to the menu");
                string userResponse = Console.ReadLine();
                if (userInput == "1")
                {
                    Problem4();
                }
                else if (userInput == "2")
                {
                    Problem5();
                }
                else if (userInput == "3")
                {
                    Problem6();
                }
                else
                {
                    Menu();
                }

            }
            else if (userInput == "3")
            {
                
            }
            else
            {
                Console.WriteLine("Enter a valid option");
                Menu();
            }

        }//End of Menu

    }// Class
}// Name
