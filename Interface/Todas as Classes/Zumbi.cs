namespace Interface
{
    public class Zumbi : ILocomocao
    {
         public void caminha() { Console.WriteLine("O zumbi caminha até seu alvo."); }
        public void correr() { Console.WriteLine("O zumbi corre instintivamente."); }
        public void rastejar() { Console.WriteLine("O zumbi rasteja até encontra algo para mastigar."); }
    }
}
