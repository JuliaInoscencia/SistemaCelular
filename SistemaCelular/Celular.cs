using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCelular
{

    public abstract class Celular
    {
        public string Marca { get; protected set; }
        public string Modelo { get; protected set; }

        public Celular(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public abstract void FazerLigacao(string numero);
        public abstract void EnviarMensagem(string numero, string mensagem);
    }

}

