namespace Dados
{
  public class Dados {

    public static string ObterNome(string x)
    {
      Console.WriteLine("Escreva seu nome");
      x = Console.ReadLine();
      return x;
    }
    public static int ObterIda (int x )
    {
      Console.WriteLine("Escreva sua idade");
      x = int.Parse (Console.ReadLine());
      return x;
    }

  }

}
