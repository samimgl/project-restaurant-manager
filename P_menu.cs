using System;
using System.Collections.Generic;

class P_menu{
  public void inicio()
  {
    Console.Clear();
    Console.WriteLine("BEM VINDO!!");
    Console.WriteLine(" ");
    Console.WriteLine("ESCOLHA UMA OPÇÃO:");
    Console.WriteLine("1) Listar os pratos;");
    Console.WriteLine("2) Anotar pedido;");
    Console.WriteLine("3) Cadastrar prato;");
    Console.WriteLine("4) Alterar prato;");
    Console.WriteLine("5) Alterar a senha;");
    Console.WriteLine("6) Sair.");
    
    switch (Console.ReadLine())
    {
      case "1": 
      P_bd cardapio = new P_bd();
      cardapio.listarPratos();
      break;
      case "2":
      P_anotaPedido anota = new P_anotaPedido();
      anota.anotaPedido();
      break;
      case "3":
      P_cadPrato novoPrato = new P_cadPrato();
      novoPrato.pratos();
      break;
      case "4":
      P_editPrato editar = new P_editPrato();
      editar.busca();
      break;
      case "5":
      P_gerenciaLogin novaSenha = new P_gerenciaLogin();
      novaSenha.altera_senha();
      break;
      case "6":
      Environment.Exit(1);
      break;
    }
  }
}
