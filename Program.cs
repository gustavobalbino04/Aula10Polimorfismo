using System;

namespace Aula10Polimorfismo
{
    class Program
    {
        //void-sem retorno
        static void Main(string[] args)
        {
            
            
            System.Console.WriteLine();
            Sonic sonic = new Sonic();
            System.Console.WriteLine();
            Dreggman dreggman = new Dreggman();
            sonic.Correr();
            dreggman.Correr();
            dreggman.Atacar();
            sonic.Enrolar();
            sonic.Atacar();
            System.Console.WriteLine("Sonic derrotou Dr.Eggman");

            
            
            

           
            



        }
    }
}
