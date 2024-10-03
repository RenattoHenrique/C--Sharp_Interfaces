namespace Interface
{
    public class Carro : IMaquina
    {
        public void Ligar() { Console.WriteLine("O Carro ligando."); }
        public void Desligar() { Console.WriteLine("O Carro desligando."); }
        public void Abastecer() { Console.WriteLine("O Carro sendo abastecido."); }
        public void Alerta() { Console.WriteLine("O Carro alerta do carro ativado."); }
    }
}
