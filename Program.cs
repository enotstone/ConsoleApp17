using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main()
        {
            BankAkk<string> DataAkkT1 = new BankAkk<string>();/* определение типа переменной в момент создания*/

            Console.WriteLine("Inter Full Name:");
            string FN = Console.ReadLine();
            Console.WriteLine("Inter Balance:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inter Num Akk:");
            string NA = Console.ReadLine();
            DataAkkT1.InputDataAkk(FN, B, NA);
            Console.WriteLine();
            DataAkkT1.OutputDataAkk();
            Console.WriteLine();
            BankAkk<ulong>/*определение типа переменной в момент создания*/ DataAkkT2 = new BankAkk<ulong>();

            Console.WriteLine("Inter Full Name:");
            string FN1 = Console.ReadLine();
            Console.WriteLine("Inter Balance:");
            int B1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inter Num Akk:");
            ulong NA1 = Convert.ToUInt64(Console.ReadLine());
            DataAkkT1.InputDataAkk(FN, B, NA);
            Console.WriteLine();
            DataAkkT1.OutputDataAkk();

            Console.ReadKey();
        }

    }

    class BankAkk<T> /* в класс с 1 переменной неопределенного типа, 
                       если их 2 и больше, указывается по количеству таких переменных
                       T - неопределенный U - универсальный */
    { 
    public T /* объявление неопределенного типа*/ NumAkk { get; set; }
        int Balance { get; set; }
        string FullName { get; set; }

        public void InputDataAkk(string FN, int B, T /* объявление неопределенного типа*/ NA) 
        {
            FullName = FN;
            Balance = B;
            NumAkk = NA;
        }
        public void OutputDataAkk()
        {
            Console.WriteLine("Full Name {0}, Balance: {1},  Num Akk: {2}", 
                FullName, Balance, NumAkk);
        }
    }
}
