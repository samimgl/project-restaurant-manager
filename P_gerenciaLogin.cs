using System;
using System.Collections.Generic;

class P_gerenciaLogin{
  public void verifica_login()
  {
    string usuario = " ";
    string senha = " ";
    
    Console.WriteLine("USUÁRIO: ");
    usuario = Console.ReadLine();
    Console.WriteLine("SENHA: ");
    senha = Console.ReadLine();

    P_menu menu = new P_menu();    
    P_login loginusuario = new P_login(usuario, senha);

    P_bd banco = new P_bd();
    bool login = banco.verifica_login(loginusuario);

    if(login == true)
    {
      menu.inicio();
    }
    else
    {
     Console.Clear();
     Console.WriteLine("Usuário ou senha incorretos...");
     Console.WriteLine(" ");
     verifica_login();
    }
  } 

  public void altera_senha()
  {
    Console.Clear();
    Console.WriteLine("Digite uma nova senha: ");
    string Nsenha = Console.ReadLine();

    P_bd banco = new P_bd();

    bool novasenha = banco.altera_senha(Nsenha);

    if(novasenha == true) 
    {
      Console.Clear();
      Console.WriteLine("Senha alterada!");
      Console.WriteLine("");
      verifica_login();
    }
  }
}
