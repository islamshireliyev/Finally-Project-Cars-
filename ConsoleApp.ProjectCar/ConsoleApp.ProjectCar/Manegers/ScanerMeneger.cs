using ConsoleApp.ProjectCar.Infrastructure;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ProjectCar.Manegers
{
    public static class ScanerMeneger
    {
        public static int ReadInteger(string caption)
        {
            l1:
            
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (!int.TryParse(Console.ReadLine(),out int value))
            {
                PrintError("Duzgun melumat deyil,yeniden cehd edin");
                goto l1;
            }
            Console.ResetColor();
            return value;
        }


        public static double ReadDouble(string caption)
        {
        l1:

            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (!double.TryParse(Console.ReadLine(), out double value))
            {
                PrintError("Duzgun melumat deyil,yeniden cehd edin");
                goto l1;
            }
            Console.ResetColor();
            return value;
        }

        public static string ReadString(string caption)
        {
        l1:

            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string value=Console.ReadLine();

            if (string.IsNullOrWhiteSpace(value))
            {
                PrintError("Duzgun melumat deyil,yeniden cehd edin");
                goto l1;
            }
            Console.ResetColor();
            return value;
        }

        public static void PrintError(string message)
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static DateTime ReadDate(string caption)
        {
        l1:
            Console.Write($"{caption} [yyyy]: ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (!DateTime.TryParseExact(Console.ReadLine(),
                "yyyy",
                null,DateTimeStyles.None, 
                out DateTime value))
            {
                PrintError("Duzgun melumat deyil,yeniden cehd edin");
                goto l1;
            }
            Console.ResetColor();
            return value;
        }

        public static Menu ReadMenu(string caption)
        {
        l1:
            Console.Write(caption);

            if (!Enum.TryParse(Console.ReadLine(), out Menu m))
            {
                PrintError("Menudan secin");
                goto l1;
            }
            Console.ResetColor();
            return m;
        }
    }
}
