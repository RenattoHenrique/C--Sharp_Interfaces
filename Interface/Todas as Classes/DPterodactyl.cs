namespace Interface
{
    public class DPterodactyl : IServivo, IVoador
    {
        public void Cair() { Console.WriteLine("O Pterodactyl está caindo!"); }
        public void Comer() { Console.WriteLine("Pterodactyl se alimentando."); }
        public void Decolar() { Console.WriteLine("O Pterodactyl levantando voo!"); }
        public void Dormir() { Console.WriteLine("O Pterodactyl indo dormir."); }
        public void Morrer() { Console.WriteLine("O Pterodactyl morre de velhice..."); }
        public void Planar() { Console.WriteLine("O Pterodactyl paira em grandes alturas"); }
        public void Pousar() { Console.WriteLine("O Pterodactyl pousa sobre as montanhas."); }
        public void Respirar() { Console.WriteLine("O Pterodactyl respira"); }
    }
}
