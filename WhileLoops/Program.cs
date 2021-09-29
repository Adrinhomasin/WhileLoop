using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt PIN-Koodi
            //programm võrdleb sisestatud PIN-Koodi arvuga 1234
            //kui sisestatud PIN-Kood on 1234
            //programm kuvab "tere tulemast!"
            //kui sisestatud PIN on vale, programm kuvab konsoolis
            //"vale pin. Proovi uuesti"
            //katsete arv on piiramatu

            bool loopActive = true;
           
            while (loopActive)
            {
                Console.WriteLine("sisesta PIN");
                int userPIN = Convert.ToInt32(Console.ReadLine());
                if(userPIN == 1234)
                {
                    Console.WriteLine("terve tuloa");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Vale pin proovi uuesti");
                    i = i + 1
                }
            }
            
            
                
        
        }

    }
}
