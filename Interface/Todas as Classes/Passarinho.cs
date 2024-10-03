namespace Interface
{
    public class Passarinho : IServivo, IVoador
    {
        public void Comer() { Console.WriteLine("O Pássaro comendo."); }
        public void Dormir() { Console.WriteLine("O Pássaro dormindo."); }
        public void Respirar() { Console.WriteLine("O Pássaro respirando."); }
        public void Morrer() { Console.WriteLine("O Pássaro morreu."); }
        public void Decolar() { Console.WriteLine("O Pássaro decolando."); }
        public void Planar() { Console.WriteLine("O Pássaro planando."); }
        public void Pousar() { Console.WriteLine("O Pássaro pousando."); }
        public void Cair() { Console.WriteLine("O Pássaro caindo."); }
    }
}
