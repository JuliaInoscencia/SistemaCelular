using System;

namespace SistemaCelular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular iPhone = new CelularApple("12 Pro");
            CelularSamsung celularSamsung = new CelularSamsung("S21");
            Celular Galaxy = celularSamsung;

            iPhone.FazerLigacao("123456789");
            Galaxy.EnviarMensagem("987654321", "Olá, como você está?");

        }
    }
}
