using System;
using System.Linq;



namespace Task_2._1._1
{
    class MyString
    {
        public char[] symbol;
        public MyString(string Input)
        {
            this.symbol = Input.ToCharArray();
        }

        public void Comparison()
        {
            Console.WriteLine("Введите строку для сравнения:    ");
            char[] compared = Console.ReadLine().ToCharArray();



            bool equal = symbol.SequenceEqual(compared);

            Console.WriteLine("Введеные строки {0}.",
                equal ? "равны" : "не равны");

        }

        public void concatenation()
        { }

        public void Search() //поиск первого вхождения символа в массив, возможно не понял задание и нужно было что-то другое
        {
            Console.WriteLine();
            Console.WriteLine("введите искомый символ:  ");
            char.TryParse(Console.ReadLine(), out char value);
            Console.WriteLine(Array.IndexOf(symbol, value));
        }

        public void ConvertToCharArr()
        {
        }

        public void PrintResult()
        {
            foreach (char a in symbol)
            {
                Console.Write(a);
            }
        }
    }


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите слово/строку:    ");
            MyString Initial = new MyString(Console.ReadLine());


            Initial.PrintResult();
            Initial.Search();
            Initial.Comparison();
        }
    }
}
