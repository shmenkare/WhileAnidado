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
            
            while(n<=5)
            {
               
               Console.Write(n);
             //Console.Write(ab);
                
                char ab = 'a';
                
                while (ab <= 'z')
                {
                    Console.Write(ab);
                    ab++;

                }
                Console.WriteLine();
                n++;
            }
            Console.ReadKey();
        }

        

    }
}
