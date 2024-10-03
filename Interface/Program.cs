using System.ComponentModel.Design;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Superman superman = new Superman();

            superman.Comer();
            superman.Dormir();
            superman.Respirar();
            superman.Morrer();
            superman.Decolar();
            superman.Planar();
            superman.Pairar();
            superman.Pousar();
            superman.Cair();

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;

            Carro carro = new Carro();

            carro.Ligar();
            carro.Desligar();
            carro.Alerta();
            carro.Abastecer();

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Cachorro cachorro = new Cachorro();
            cachorro.Comer();
            cachorro.Dormir();
            cachorro.Respirar();
            cachorro.Morrer();

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;

            Passarinho passarinho = new Passarinho();
            passarinho.Decolar();
            passarinho.Comer();
            passarinho.Respirar();
            passarinho.Morrer();
            passarinho.Dormir();
            passarinho.Planar();
            passarinho.Pousar();
            passarinho.Cair();

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            DTRex dTRex = new DTRex();
            dTRex.Respirar();
            dTRex.Morrer();
            dTRex.Comer();
            dTRex.Dormir();

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Gato gato = new Gato();
            gato.Comer();
            gato.Dormir();
            gato.Respirar();
            gato.Morrer();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Zumbi zumbi = new Zumbi();
            zumbi.rastejar();
            zumbi.correr();
            zumbi.caminha();

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("\nE demais seres do programa...");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine();


        }
    }
}