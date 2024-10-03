namespace Interface
{
    public class BeijaFlor : IServivo, IVoador
    {
        public void Comer() { Console.WriteLine("Beija-Flor comendo."); }
        public void Dormir() { Console.WriteLine("Beija-Flor dormindo."); }
        public void Respirar() { Console.WriteLine("Beija-Flor respirando."); }
        public void Morrer() { Console.WriteLine("Beija-Flor morreu."); }
        public void Decolar() { Console.WriteLine("Beija-Flor decolando."); }
        public void Planar() { Console.WriteLine("Beija-Flor planando."); }
        public void Pousar() { Console.WriteLine("Beija-Flor pousando."); }
        public void Cair() { Console.WriteLine("Beija-Flor caindo!"); }
    }
}
