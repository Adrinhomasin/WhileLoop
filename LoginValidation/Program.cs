﻿using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisestage kasutajatunnus");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisestage parool");
                string userPass = Console.ReadLine();

                if (userName == "admin" && userPass == "admin1234")
                {
                    Console.WriteLine("tere tulemast");
                    break;
                }
                else
                {
                    Console.WriteLine("sisselogimine ebaõnnestus proovige uuesti");
                    i = i + 1;
                    
                }
            }
           
        }
    }
}
