using System;
using System.Collections.Generic;
class P_cadPrato{
    public void pratos(){
      string nome = " ";
      double preco = 0;
      string descricao =" ";

      Console.Clear();
      
      Console.WriteLine("Digite o nome do prato:");
      nome = Console.ReadLine();
      Console.WriteLine(" ");
      Console.WriteLine("Digite o preço do prato:");
      preco = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine(" ");
      Console.WriteLine("Digite a descrição do prato:");
      descricao = Console.ReadLine();

      P_prato novoPrato =  new P_prato(nome, "", preco, descricao);

      P_bd BD = new P_bd();
      BD.Cad_prato(novoPrato);

      Console.WriteLine(" ");
      Console.WriteLine("PRATO CADASTRADO COM SUCESSO!");
      Console.WriteLine(" ");
      Console.WriteLine("aperte enter para voltar ao menu :)");

      Console.ReadKey();

      P_menu menu = new P_menu();
      menu.inicio();
    }
}
