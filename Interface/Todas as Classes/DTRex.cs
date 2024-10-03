namespace Interface
{
    public class DTRex : IServivo
    {
        public void Comer() { Console.WriteLine("O T-Rex comendo."); }
        public void Dormir() { Console.WriteLine("O T-Rex dormindo."); }
        public void Respirar() { Console.WriteLine("O T-Rex respirando."); }
        public void Morrer() { Console.WriteLine("O T-Rex morreu."); }
    }
}
