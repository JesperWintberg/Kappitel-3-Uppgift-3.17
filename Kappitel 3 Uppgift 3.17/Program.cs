using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal");
            Console.WriteLine("tal 1:");  
            string tal1 = Console.ReadLine();
            Console.WriteLine("tal 2:"); 
            string tal2 = Console.ReadLine();

            float talen1 = float.Parse(tal1);
            float talen2 = float.Parse(tal2);   

 
            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            string kategori = Console.ReadLine();

            float svar1 = talen1 + talen2;
            float svar2 = talen2 - talen1;
            float svar3 = talen1 * talen2;
            float svar4 = talen2 / talen1;  

            switch (kategori)
            {
                case "1":
                    Console.WriteLine("Ditt svar belv " + svar1);
                    break;

                case "2":
                    Console.WriteLine("Ditt svar blev " + svar2);
                    break;

                case "3":
                    Console.WriteLine("Ditt svar blev " + svar3);
                    break;

                case "4":
                    Console.WriteLine("Ditt svar blev " + svar4);
                    break;  
                default:
                    Console.WriteLine("Min matte dålig");
                    break;
            }
                

            

        }
    }
}

