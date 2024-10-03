namespace Interface
{
    public class Fantasma : IVoador
    {
        public void Decolar() { Console.WriteLine("Fantasma flutuando."); }
        public void Planar() { Console.WriteLine("Fantasma planando."); }
        public void Pousar() { Console.WriteLine("Fantasma descendo."); }
        public void Cair() { Console.WriteLine("Fantasma não cai."); }
    }
}
