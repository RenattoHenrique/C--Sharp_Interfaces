namespace Interface
{
    public class Helicoptero : IMaquina, IVoador
    {
        public void Decolar() { Console.WriteLine("Helicóptero decolando."); }
        public void Planar() { Console.WriteLine("Helicóptero planando."); }
        public void Pousar() { Console.WriteLine("Helicóptero pousando."); }
        public void Cair() { Console.WriteLine("Helicóptero caindo!"); }
        public void Ligar() { Console.WriteLine("Helicóptero ligando."); }
        public void Desligar() { Console.WriteLine("Helicóptero desligando."); }
        public void Abastecer() { Console.WriteLine("Helicóptero abastecendo."); }
        public void Alerta() { Console.WriteLine("Alerta do helicóptero ativado."); }
    }
}
