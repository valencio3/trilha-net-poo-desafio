namespace DesafioPOO.Models;

public abstract class Smartphone(string numero, string modelo, string imei, int memoria)
{
  public string Numero = numero;
  private string Modelo { get; } = modelo;
  private string IMEI { get; } = imei;
  private int Memoria { get; } = memoria;

  public void Ligar()
  {
    Console.WriteLine("Ligando...");
  }

  public void ReceberLigacao()
  {
    Console.WriteLine("Recebendo ligação...");
  }

  public abstract void InstalarAplicativo(string nomeApp);
}
