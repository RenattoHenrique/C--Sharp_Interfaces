namespace Interface
{
    public class Gato : IServivo
    {
        public void Comer() { Console.WriteLine("O Gato comendo."); }
        public void Dormir() { Console.WriteLine("O Gato dormindo."); }
        public void Respirar() { Console.WriteLine("O Gato respirando."); }
        public void Morrer() { Console.WriteLine("O Gato morreu."); }
    }
}
