using System.Threading;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Download do aplication '{nomeApp}' de Android Store . . .");
            Console.WriteLine($"Instalando o aplicativo {nomeApp} . . .");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine($"Aplicativo '{nomeApp}' Instalado com sucesso.");
        }
    }
}