namespace Interface
{
    public class Trem : IMaquina
    {
        public void Ligar() { Console.WriteLine("Trem ligando."); }
        public void Desligar() { Console.WriteLine("Trem desligando."); }
        public void Abastecer() { Console.WriteLine("Trem sendo abastecido."); }
        public void Alerta() { Console.WriteLine("Alerta do trem ativado."); }
    }
}
