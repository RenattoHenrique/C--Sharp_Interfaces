namespace Interface
{
    public class Cachorro : IServivo
    {
        public void Comer() { Console.WriteLine("O Cachorro comendo."); }
        public void Dormir() { Console.WriteLine("O Cachorro dormindo."); }
        public void Respirar() { Console.WriteLine("O Cachorro respirando."); }
        public void Morrer() { Console.WriteLine("O Cachorro morreu."); }
    }
}
