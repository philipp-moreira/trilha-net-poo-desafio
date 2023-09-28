namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Download do aplication '{nomeApp}' de Apple Store . . .");
            Console.WriteLine($"Instalando o aplicativo {nomeApp} . . .");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine($"Aplicativo '{nomeApp}' Instalado com sucesso.");
        }
    }
}