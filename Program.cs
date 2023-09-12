using System;
using System.Collections.Generic;
using System.Text;

namespace WhileAnidado
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            char ab = ' ';


            while(n<=5)
            {
                ab = 'a';
            Console.Write(n);
                n++;

                //Console.Write(ab);
               
                while (ab <= 'z')
                {
                    Console.Write(ab);
                    ab++;

                }
                Console.WriteLine();
            
            }
            Console.ReadKey();
        }

        

    }
}
