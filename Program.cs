using System;

namespace _Net_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //طول المتغيرات
            Console.WriteLine("byte");
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine("--------------");
            Console.WriteLine("float");
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine("--------------");
            Console.WriteLine("int");
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine("--------------");

            //دمج النصوص
            String First_name="Muteb";
            String List_name="Alsharari";

            String All_name="The name is:"+First_name+" "+List_name;

            Console.WriteLine(All_name);
          //العمليات الرياضية
          float n1=12;
          float n2=144;

          float Add=n1+n2;
          float mul=n1*n2;
          Console.WriteLine(Add);
          Console.WriteLine(mul);
          Console.WriteLine(n1-n2);
          Console.WriteLine(n1/n2);
          


          {
              
          }




            {
                
            }
        }
    }
}
