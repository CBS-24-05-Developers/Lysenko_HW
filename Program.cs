using System;

namespace HW7._2
{
    class Program
    {
        static double Convdollar(double currencyamount)
        {
            double dollarval = 27.1068;
            return currencyamount * dollarval;
        }

        static double Conveuro(double currencyamount)
        {
            double euroval = 32.989;
            return currencyamount * euroval;
        }

        static double Convpound(double currencyamount)
        {
            double poundval = 38.2436;
            return currencyamount * poundval;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму для конвертации :");
            string curam = Console.ReadLine();
            double currencyamount = Convert.ToDouble(curam);

            double converted = Convdollar(currencyamount);

            Console.WriteLine("Выберите валюту для конвертациию");
            Console.WriteLine("Dol - для конвертации долларов");
            Console.WriteLine("Eur - для конвертации евро");
            Console.WriteLine("Pou - для конвертации фунтов");
            string chosencurrency = Console.ReadLine();

            if (chosencurrency == "Dol")
            {
                converted = Convdollar(currencyamount);
            }
            else if(chosencurrency == "Eur")
            {
                converted = Conveuro(currencyamount);
            }
            else if (chosencurrency == "Pou")
            {
                converted = Convpound(currencyamount);
            }
           
            Console.WriteLine($"Сумма составляет : {converted} гривен");
            Console.ReadKey();


        }
    }
}
