using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properte_ex
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int ch;
            bool br = true;
            Tell t1 = new Tell();
            do {
                t1.List_all();
                Console.Write("Enter Your Choies:");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch) {
                    case 1:
                        t1.Add_new();
                        break;
                    case 2:
                        t1.Show_all();
                        break;
                    case 3:
                        t1.Search();
                        break;
                    case 0:
                        br = false;
                        Console.WriteLine("Thank You For Using Program");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Error Couies");
                        break;
                }


            } while (br!=false);
        }
    }
}
