namespace SistemaCelular
{
    using System;

    public class CelularSamsung : Celular
    {
        public CelularSamsung(string modelo) : base("Samsung", modelo)
        {
        }

        public override void FazerLigacao(string numero)
        {
            Console.WriteLine($"Ligando de um Samsung {Modelo} para o número {numero}");
        }

        public override void EnviarMensagem(string numero, string mensagem)
        {
            Console.WriteLine($"Enviando mensagem de texto de um Samsung {Modelo} para o número {numero}: {mensagem}");
        }
    }

}
