using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"1.Пользователь вводит строку, вывести на экран информацию:
а.Сколько симвлов в данной строке
б.Сколько цифр в строке
в.Сколько букв в верхнем регистре
г.Сколько букв в нижнем регистре
д.Количество предложений в строке");
            string someString = Console.ReadLine();

            //a
            LengthString(someString);
            //б
            CountNumbers(someString);
            //в
            CountUpper(someString);
            //г
            CountLower(someString);
            //д
            CountSentence(someString);

            Console.WriteLine(@"2.Пользователь вводит строку и символ.
а.В строке найти все вхождения данного символа и перевести его в верхний регистр.
б.Подсчитать сколько раз данный символ распологается в начале слова");
            someString = Console.ReadLine();
            char someChar =Convert.ToChar( Console.ReadLine());

            Console.ReadKey();
        }

        static void LengthString(string someString)
        {
            var LengthString = someString.Length;
            Console.WriteLine("a)" + LengthString);
        }

        static void CountNumbers(string someString)
        {
          
            var res = someString.Where(t => Char.IsDigit(t)).Count();

            Console.WriteLine("б)" + res);
        }

        static void CountUpper(string someString)
        {
            var res = someString
                .Where(t => Char.IsUpper(t))
                .Count();

            Console.WriteLine("в)" + res);
        }

        static void CountLower(string someString)
        {
            var res2 =  someString.
                        Where(t => Char.IsLower(t))
                        .Count();

            Console.WriteLine("г)" + res2);
        }
        static void CountSentence(string someString)
        {
            int count = 1;
            foreach (var i in someString)
            {
                    switch (i)
                    {
                        case '.':
                            count++;
                            break;
                        case '?':
                            count++;
                            break;
                        case '!':
                            count++;
                            break;
                    }
            }
            Console.WriteLine("д)"+count);

            //var res = someString.Where(t => t == ',' || t == '?' || t == '!')
            //    .Count();
            //Console.WriteLine("var: {0}", res);
        }
        static void ToUpper(string someString,char someChar)
        {
            string NewSomeString="";
            var res = someString.Where(t => t == someChar);


            foreach(var t in res)
                {
                    String.Concat(NewSomeString, t);
                }
            Console.WriteLine("а.{0}",NewSomeString);
        }
    }
}
