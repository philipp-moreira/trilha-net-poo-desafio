using System.Collections;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; private set; }
        protected string Modelo { get; init; }
        protected string Imei { get; init; }
        protected int Memoria { get; init; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public virtual void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public virtual void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public override string ToString()
        {
            return $"MODELO: {Modelo} - IMEI: {Imei} - MEMORIA: {Memoria} - NUMERO: {Numero} ";
        }
    }
}