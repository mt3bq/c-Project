using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properte_ex
{
    class Tell
    {
        //المتغيرات
        private int[] id=new int[100];
        private string[] name=new string[100];
        private string[] Phone_Number=new string[100];
        private string[] back = new string[100];
        private int k = 1;
        private string Search_aera;

        //الخصائص
        //public int id_pro{

        //get { return id[k]; }
        //set {  this.id[k]=value; }

        //}

        //public string name_prp {
        //    get { return name[k]; }
        //    set { this.name[k] = value; }
        //}
        //public int phone_num_pro {

        //get { return Phone_Number[k]; }
        //set { this.Phone_Number[k] = value; }
        //}
        //الوظائف
        public void List_all() {
            Console.WriteLine("[1]Add New");
            Console.WriteLine("[2]Show All");
            Console.WriteLine("[3]Search");
            Console.WriteLine("[0]Exit");
            Console.WriteLine("############");

        }
        public void Add_new() {
            do {
                Console.WriteLine("**********************");
                
                Console.WriteLine("Uesr "+k);
                Console.Write("Enter Your Nmae:");
                name[k] = Console.ReadLine();
                Console.Write("Enter Your Phone Number:");
                Phone_Number[k] = Console.ReadLine();
                Console.Write("If You need Baack [back] or not [c]:");
                back[k] = Console.ReadLine();
            } while (back[k++]!="back");


        }
        public void Show_all() {
           
            Console.WriteLine("**********************");
            Console.WriteLine("ID\tName\tPhone Number");
            for (int i = 0; i < k; i++) {

                Console.WriteLine(i+1+"\t"+name[i]+"\t"+Phone_Number[i]);
            }
            Console.WriteLine("**********************");



        }
        public void Search()
        {
            Console.WriteLine("**********************");
            Console.Write("Enter Nme or Phone Number Yoy Need Search:");
            Search_aera= Console.ReadLine();
            for (int j = 0; j <k;j++) {
                if (Search_aera==name[j]|| Search_aera==Phone_Number[j]) {
                    Console.WriteLine("**********************");
                    Console.WriteLine("ID\tName\tPhone Number");
                    
                
                        Console.WriteLine(j + 1 + "\t" + name[j] + "\t" + Phone_Number[j]);
                        Console.WriteLine("**********************");
                    break;
                    
                    
                } else {
                    Console.WriteLine("Not Fond");
                }
            }


       

        }

    }
}
