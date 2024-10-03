namespace Interface
{
    public class Aviao : IMaquina, IVoador
    {
        public void Decolar() { Console.WriteLine("Avião decolando."); }
        public void Planar() { Console.WriteLine("Avião planando."); }
        public void Pousar() { Console.WriteLine("Avião pousando."); }
        public void Cair() { Console.WriteLine("Avião caindo!"); }
        public void Ligar() { Console.WriteLine("Avião ligando."); }
        public void Desligar() { Console.WriteLine("Avião desligando."); }
        public void Abastecer() { Console.WriteLine("Avião abastecendo."); }
        public void Alerta() { Console.WriteLine("Alerta do avião ativado."); }
    }
}
