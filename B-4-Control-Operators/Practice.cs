using System;
using System.Data.SqlClient;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //Сложение двух чисел с проверкой
        public static void B3_P2_9_CheckResultAddition()
        {
            int x, y, z;
            int check;
            Console.Write("Введите первое число: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            y = Convert.ToInt32(Console.ReadLine());
            z = x + y;
          
            for (int i = 0; i < 3; i++)
            {

                Console.Write("Введите предполагаемый ответ:");
                check = Convert.ToInt32(Console.ReadLine());

                if (check == z)
                {
                    Console.WriteLine("Ответ верный!");
                    break;
                }
                else
                {
                    Console.WriteLine("Ответ неверный. Верный ответ:" + z);
                }
            }
        }
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
            var time = DateTime.Now.TimeOfDay;
            string timestring = Convert.ToString(time);
            var charsToRemove = new string[] {":", "."};
            foreach (var c in charsToRemove)
            {
                timestring = timestring.Replace(c, string.Empty);
            }
            timestring = timestring.Substring(0, timestring.Length-11);
            var timestringtoint = Convert.ToInt64(timestring);
            if (timestringtoint < 12 && timestringtoint > 6 )
            {
                Console.WriteLine("Доброе утро, Ольга!");
            }else if(timestringtoint > 12 && timestringtoint < 18)

            {
                Console.WriteLine("Добрый день, Ольга!");
            }
            else
            {
                Console.WriteLine("Добрый вечер, Ольга!");
            }

        }

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
            int x, y, z;
            Console.Write("Введите два числа: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if (x==y)
            {
                Console.WriteLine("Числа равны!");
            }else if(x>y)
            {
                z = x - y;
                Console.WriteLine("Значение X больше Y на " + z);
            }
            else
            {
                z = y - x;
                Console.WriteLine("Значение X меньше Y на " +z);
            }
        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing() //Не до конца понял в чем суть задачи была(((
        {
            int x, y, z;
            Console.Write("Введите два числа: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if (y>0 && y==0)
            {
                if (x == y)
                {
                    Console.WriteLine("Числа равны!");
                }
                else
                {
                    z = x - y;
                    Console.WriteLine("Значение X больше Y на " + z);
                }
            }
            else
            {
                Console.WriteLine("Второе число меньше нуля!Введите число больше нуля");
                y = Convert.ToInt32(Console.ReadLine());
            }
          }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()

        {
            Console.WriteLine("Загадайте число от 1 до 5");
            int x;
            
        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
            var today = DateTime.Today;
            var dayOfWeek = (int)today.DayOfWeek;
            switch (dayOfWeek-1)
            {
                case 0: 
                    Console.WriteLine("Доброго понедельника, Олга!");
                    break;
                case 1:
                    Console.WriteLine("Доброго вторника, Олга!");
                    break;
                case 2:
                    Console.WriteLine("Доброй среды, Олга!");
                    break;
                case 3:
                    Console.WriteLine("Доброго четверга, Олга!");
                    break;
                case 4:
                    Console.WriteLine("Доброй пятницы, Олга!");
                    break;
                case 5:
                    Console.WriteLine("Доброй субботы, Олга!");
                    break;
                case 6:
                    Console.WriteLine("Доброго воскресенья, Олга!");
                    break;
            }

        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {
            LabelStart:

            var batton = Console.ReadKey();
            Console.WriteLine();
            switch (batton.KeyChar)
            {
                case 'w':
                    Console.WriteLine("Движение вверх");
                    break;
                case 'W':
                    Console.WriteLine("Движение вверх");
                    break;
                case 'a':
                    Console.WriteLine("Движение влево");
                    break;
                case 'A':
                    Console.WriteLine("Движение влево");
                    break;
                case 's':
                    Console.WriteLine("Движение вниз");
                    break;
                case 'S':
                    Console.WriteLine("Движение вниз");
                    break;
                case 'd':
                    Console.WriteLine("Движение вправо");
                    break;
                case 'D':
                    Console.WriteLine("Движение вправо");
                    break;
           }

            goto LabelStart;
        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
            
        }


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
        }


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
           
        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {
            
        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            
        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
            
        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
           
        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            
        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {
            
        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            
        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            
        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            double a, b, c;
            char symbol = ' ';
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите операцию ('+','-','*','/'): ");
            symbol = Convert.ToChar(Console.ReadLine());
            if (symbol == '+')
            {
                c = a + b;
            }
            else if (symbol == '-')
            {
                c = a - b;
            }
            else if (symbol == '*')
            {
                c = a * b;
            }
            else
            {
                c = a / b;
            }

            Console.WriteLine($"Результат: "+c);
        
    }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {
            double a, b, c;
            char symbol = ' ';
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите операцию ('+','-','*','/'): ");
            symbol = Convert.ToChar(Console.ReadLine());
            switch (symbol)
            {
                case '+': c = a + b;
                    Console.WriteLine($"Результат: " + c);
                    break;
                case '-':
                    c = a - b;
                    Console.WriteLine($"Результат: " + c);
                    break;
                case '*':
                    c = a * b;
                    Console.WriteLine($"Результат: " + c);
                    break;
                case '/':
                    c = a / b;
                    Console.WriteLine($"Результат: " + c);
                    break;
                default: Console.WriteLine("Not supported operation"); break;
            }
        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
            string word;
            Console.WriteLine("Введите любое слово: ");
            word = Console.ReadLine();
            char[] wordinarray = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                wordinarray[i] = word[i];
            }
            Array.Reverse(wordinarray); //Был очень приятно удивлен что уже есть готовый класс и метод для работы с массивами.
            Console.WriteLine(wordinarray);
        }
    }
}
