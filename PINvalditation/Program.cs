using System;

namespace PINvalditation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            int i = 0;

            while (i < 3)
               
            {
                Console.WriteLine("sisesta PIN");
                int pin = Convert.ToInt32(Console.ReadLine());
                
                if (pin == 1234)
                {
                    Console.WriteLine("tere tulemast");
                    break;
                }
                else if (i < 3)                         
                {
                    Console.WriteLine("proovi uuesti");
                    i = i + 1;                    
                }


            }
        }
    }
}
