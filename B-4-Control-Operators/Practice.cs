using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
            var hour=0;
            Console.WriteLine(hour = DateTime.Now.Hour+2);
            if (hour>10 && hour <= 18)
            {
                Console.WriteLine("Good afternoon");
            }
            else if (hour > 18 | hour<5)
            {
                Console.WriteLine("Good night");
            }
            else
            {
                Console.WriteLine("Good morning");

            }
        }

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
            Console.WriteLine("Enter X");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x == y)
            {
                Console.WriteLine("Values are equal");

            }
            else if (x < y)
            {
                Console.WriteLine("X is less than Y at "+(y-x));

            }
            else {
                Console.WriteLine("X is bigger than Y at " + (x-y));

            }

        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
            Console.WriteLine("Enter X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x>=0 && y>=0)
            {
                if (x == y)
                {
                    Console.WriteLine("Values are equal");

                }
                else if (x < y)
                {
                    Console.WriteLine("X is less than Y at " + (y - x));

                }
                else
                {
                    Console.WriteLine("X is bigger than Y at " + (x - y));

                }

            }
            else
            {
                Console.WriteLine("This programm compares only numbers greater or equal 0");
            }

        }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {
            Console.WriteLine("Guess the number from 1 to 5");
            Console.WriteLine("Is this number is 1? press (y/n)");
            string answer=Console.ReadLine();
            if (answer == "n")
            {
                Console.WriteLine("Is this number is 2? press (y/n)");
                answer = Console.ReadLine();
                if (answer == "n")
                {
                    Console.WriteLine("Is this number is 3? press (y/n)");
                    answer = Console.ReadLine();
                    if (answer == "n")
                    {
                        Console.WriteLine("Is this number is 4? press (y/n)");
                        answer = Console.ReadLine();
                        if (answer == "n")
                        {
                            Console.WriteLine("This number is 5. Well done!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Well done!");
                    }
                }
                else
                {
                    Console.WriteLine("Well done!");
                }
            }
            else
            {
                Console.WriteLine("Well done!");
            }

        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
            Console.WriteLine("Happy "+DateTime.Now.DayOfWeek+" Olga");
        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {
            move:
            string direction=Console.ReadLine();
            switch (direction)
            {
                case "w":
                    Console.WriteLine("up");
                    goto move;
                case "d":
                    Console.WriteLine("right");
                    goto move;
                case "a":
                    Console.WriteLine("left");
                    goto move;
                case "s":
                    Console.WriteLine("back");
                    goto move;

            }

        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
            for (int i = 1; i < 11; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i+" - even");
                }
                else
                {
                    Console.WriteLine(i + " - odd");
                }
            }
        }


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
            for (int i = 30; i >= 0; i--)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Hello, world");
            }
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {
        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
            for (int i = 0; i >-11; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is even");
                }
                else
                {
                    Console.WriteLine(i + " is odd");
                }
            }
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            string word = Console.ReadLine();
            int length = word.Length;
            char letter = 'a';
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (letter==word[i])
                {
                    count = count + 1;
                }
            }
            Console.WriteLine(count);
        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            for (int i = 90; i > 64; i--)
            {
                Console.WriteLine(Convert.ToChar(i));
            }
            
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
            Console.WriteLine("Enter range:");
            Console.WriteLine("Enter first number of range");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter last number of range");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int i = number1;
            while (i>=number1 && i <= number2)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " - even");
                }
                i++;
            }

        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
            Console.WriteLine("Enter range:");
            Console.WriteLine("Enter first number of range");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter last number of range");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int i = number1;
            do
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i + " - odd");
                }
                i++;
            }
            while (i >= number1 && i <= number2);

        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
            int i = 0;
            while (i<6)
            {
                Console.WriteLine("Hello world");
                i++;
            }
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter exponent");
            int exponent = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int number1 = 1;
            while (i < exponent)
            {
                Console.WriteLine(number+"^"+(i+1)+"="+(number1=number1*number));
                i++;
            }

        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {
            Console.WriteLine("2+2=?");
            int answer=Convert.ToInt32(Console.ReadLine());
            if (answer == 2)
            {
                Console.WriteLine("Well done!");
            }
            else
            {
                while (answer != 2)
                {
                    Console.WriteLine("Wrong answer. Try again");
                    answer = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Well done!");
            }
        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            int position1 = 0;
            int position2 = 0;
            int step = 0;
            int finish = 25;
            while (position1<finish && position2<finish )
            {
                Console.WriteLine("Player1, enter step (1...6)");
                step = Convert.ToInt32(Console.ReadLine());
                position1 = position1 + step;
                Console.WriteLine("Player1, your current position " + position1 + "/25");
                Console.WriteLine("Player2, your current position " + position2 + "/25");
                Console.WriteLine("Player2, enter step (1...6)");
                step = Convert.ToInt32(Console.ReadLine());
                position2 = position2 + step;
                Console.WriteLine("Player2, your current position " + position2 + "/25");
                Console.WriteLine("Player1, your current position " + position1 + "/25");
            }
            Console.WriteLine("Finish!");
            if (position1 < finish)
            {
                Console.WriteLine("Player2 is a winner!");
            }
            else if (position1>=finish && position2>=finish)
            {
                Console.WriteLine("It's a draw!");
            }
            else
            {
                Console.WriteLine("Player1 is a winner!");
            }
            
        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void B4_P21_25_While_DiceGameMultiplePlayers()
        {
            int position1 = 0;
            int position2 = 0;
            int step = 0;
            int finish = 25;
            while (position1 < finish && position2 < finish)
            {
                Console.WriteLine("Player1, enter step (1...6)");
                step = Convert.ToInt32(Console.ReadLine());
                position1 = position1 + step;
                Console.WriteLine("Player1, your current position " + position1 + "/25");
                Console.WriteLine("Player2, your current position " + position2 + "/25");
                Console.WriteLine("Player2, enter step (1...6)");
                step = Convert.ToInt32(Console.ReadLine());
                position2 = position2 + step;
                Console.WriteLine("Player2, your current position " + position2 + "/25");
                Console.WriteLine("Player1, your current position " + position1 + "/25");
            }
            Console.WriteLine("Finish!");
            if (position1 < finish)
            {
                Console.WriteLine("Player2 is a winner!");
            }
            else if (position1 >= finish && position2 >= finish)
            {
                Console.WriteLine("It's a draw!");
            }
            else
            {
                Console.WriteLine("Player1 is a winner!");
            }
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            Console.WriteLine("Guess the number");
            string answer1 = "n";
            string answer2 = "n";
            int a = 0;
            int b = 100;
            int c = 0;
            while (answer2 == "n")
            {
                Console.WriteLine("Your number>"+((a+b)/2)+"(y/n)");
                c = (a + b) / 2;
                answer1 =Console.ReadLine();
                if (answer1 == "y")
                {
                    a = c;
                }
                else
                {
                    b = c;
                }
                if (Math.Abs(a-b)==1)
                {
                    Console.WriteLine("Is " + c + " your number?");
                    answer2=Console.ReadLine();
                }
                if (c == 0)
                {
                    Console.WriteLine("Your number is 0. Wright?");
                    answer2 = Console.ReadLine();
                }
                if (c >= 99 && answer2=="n")
                {
                    Console.WriteLine("Your number is 100. Wright?");
                    answer2 = Console.ReadLine();
                }

            }
            Console.WriteLine("Well done!");
        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            Console.Write("Enter number 1: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator: ");
            char oper = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter number 2: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double result;
            if (oper == '+')
            {
                result = number1 + number2;
                Console.WriteLine(number1 + "+" + number2 + "=" + result);
            }
            if (oper == '-')
            {
                result = number1 - number2;
                Console.WriteLine(number1 + "-" + number2 + "=" + result);

            }
            if (oper == '*')
            {
                result = number1 * number2;
                Console.WriteLine(number1 + "*" + number2 + "=" + result);

            }
            if (oper == '/')
            {
                result = number1 / number2;
                Console.WriteLine(number1 + "/" + number2 + "=" + result);

            }


        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {
            Console.Write("Enter number 1: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator: ");
            char oper = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter number 2: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double result;
            switch (oper)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine(number1+"+"+number2+"="+result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine(number1 + "-" + number2 + "=" + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine(number1 + "*" + number2 + "=" + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine(number1 + "/" + number2 + "=" + result);
                    break;
            }
        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine();
            int word_lenght = word.Length;
            Console.Write("Reverse word: ");
            for (int i = word_lenght-1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
        }
    }
}
