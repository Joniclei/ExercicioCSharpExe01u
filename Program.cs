using System;

namespace Dados
{

  public class Program
  {

    public static void Main(String[] args)
    {
      string nameA,nameB ;
      int idadeA = 0,idadeB = 1;
      string resultado;

      nameA = Dados.ObterNome("nameA");
      idadeA = Dados.ObterIda(idadeA);


      nameB = Dados.ObterNome("nameB");
      idadeB = Dados.ObterIda(idadeB);

      resultado = idadeA > idadeB ? ($" {nameA} e mais velho(a) que {nameB}") : ($" {nameB} e mais velho(a) que {nameA}") ;

      Console.WriteLine(resultado);

  }
  }
}
