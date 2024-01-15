namespace SistemaCelular
{
    using System;

    public class CelularApple : Celular
    {
        public CelularApple(string modelo) : base("Apple", modelo)
        {
        }

        public override void FazerLigacao(string numero)
        {
            Console.WriteLine($"Ligando de um iPhone {Modelo} para o número {numero}");
        }

        public override void EnviarMensagem(string numero, string mensagem)
        {
            Console.WriteLine($"Enviando mensagem de texto de um iPhone {Modelo} para o número {numero}: {mensagem}");
        }
    }

}
