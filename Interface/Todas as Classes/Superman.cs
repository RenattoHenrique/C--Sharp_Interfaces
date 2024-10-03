namespace Interface
{
    public class Superman : IServivo, IPairador, IVoador
    {
        public void Comer() { Console.WriteLine("O Superman comendo."); }
        public void Dormir() { Console.WriteLine("O Superman dormindo."); }
        public void Respirar() { Console.WriteLine("O Superman respirando."); }
        public void Morrer() { Console.WriteLine("O Superman nunca morre."); }
        public void Decolar() { Console.WriteLine("O Superman decolando."); }
        public void Planar() { Console.WriteLine("O Superman planando."); }
        public void Pousar() { Console.WriteLine("O Superman pousando."); }
        public void Cair() { Console.WriteLine("O Superman caindo."); }
        public void Pairar() { Console.WriteLine("O Superman pairando."); }
    }
}
