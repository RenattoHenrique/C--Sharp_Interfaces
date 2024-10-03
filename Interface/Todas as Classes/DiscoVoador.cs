namespace Interface
{
    public class DiscoVoador : IMaquina, IVoador
    {
        public void Decolar() { Console.WriteLine("Disco voador decolando."); }
        public void Planar() { Console.WriteLine("Disco voador planando."); }
        public void Pousar() { Console.WriteLine("Disco voador pousando."); }
        public void Cair() { Console.WriteLine("Disco voador caindo!"); }
        public void Ligar() { Console.WriteLine("Disco voador ligando."); }
        public void Desligar() { Console.WriteLine("Disco voador desligando."); }
        public void Abastecer() { Console.WriteLine("Disco voador sendo abastecido."); }
        public void Alerta() { Console.WriteLine("Alerta do disco voador ativado."); }
    }
}
