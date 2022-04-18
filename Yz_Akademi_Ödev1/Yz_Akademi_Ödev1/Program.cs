using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yz_Akademi_Ödev1
{
    class Program
    {
        private static void Title() {
            Console.WriteLine("     **************************************");
            Console.WriteLine("     ******* POINTS OF THE REVIEWER *******");
            Console.WriteLine("     **************************************");
            Console.WriteLine("     *********Rate Points 1 to 100*********");
        }
            
       
        static void Main(string[] args)
        {
            Title();
            Console.WriteLine();
            string[]properties= { "Clarity", "Orginality", "Difficulty" };
            
            int[] a = new int[3];
            int[] b = new int[3];
            int[,] finalresult = new int[1,2];
            finalresult[0, 0] = 0;
            finalresult[0, 1] = 0;
           
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    Console.Clear();
                    Title();
                    Console.WriteLine();
                    Console.WriteLine("     ***" + properties[i] + "***");
                    Console.Write(" Alice:   ");
                    a[i] = int.Parse(Console.ReadLine());
                } while (a[i] < 1 || a[i] > 100) ;
                
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    Console.Clear();
                    Title();
                    Console.WriteLine();
                    Console.WriteLine("     ***" + properties[i] + "***");
                    Console.Write(" Bob:   ");
                    b[i] = int.Parse(Console.ReadLine());
                } while (b[i] < 1 || b[i] > 100);

                Console.WriteLine();
            }

            for (int i = 0; i <= 2; i++)
            {
                if (a[i] > b[i])
                {
                    finalresult[0, 0] += 1;
                }
                if (a[i] < b[i])
                {
                    finalresult[0, 1] += 1;
                }
            }
              Console.Clear();
            Console.WriteLine("        " + properties[0] + "     " + properties[1] + "    " + properties[2]);

            Console.Write(" Alice:    ");
            for (int i = 0; i <= 2; i++)
            {
                Console.Write(String.Format("{0,-13}",a[i]));


            }
            Console.WriteLine();
            Console.Write("   Bob:    ");
            for (int i = 0; i <= 2; i++)
            {
                Console.Write(String.Format("{0,-13}", b[i]));

            }
            
            Console.Write(String.Format("\n\n{0,44}", "Final Points"));
            Console.Write("\n                        Alice:       " + finalresult[0, 0]);
            Console.Write("\n                          Bob:       " + finalresult[0, 1]);

                               

            Console.Read();



        }
    }
}
