namespace DesafioPOO.Models;
public class Iphone(string numero, string modelo, string imei, int memoria) : Smartphone(numero, modelo, imei, memoria)
{
	public override void InstalarAplicativo(string nomeApp) => Console.WriteLine($"Instalnado o aplicativo {nomeApp}");
}
