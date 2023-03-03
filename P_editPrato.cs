using System;

class P_editPrato{
  public void busca(){
    Console.Clear();

    Console.WriteLine("Digite o nome do prato para busca:");
    string nome = Console.ReadLine();

    P_bd banco = new P_bd();
    P_prato prato = banco.Busca_prato(nome);

    if( prato.nome != " "){
        Console.WriteLine(" ");
        Console.WriteLine("Nome: " + prato.nome);
        Console.WriteLine("Preço: " + prato.preco);
        Console.WriteLine("Descrição: " + prato.descricao);
        Console.WriteLine(" ");
        Console.WriteLine("Você deseja:");
        Console.WriteLine("(A) EDITAR?");
        Console.WriteLine("(B) EXCLUIR?"); 
        Console.WriteLine("ou pressione enter para voltar ao Menu.");

        string resposta = Console.ReadLine();
        if(resposta =="A")
          altera(prato);
        else
          if(resposta == "B")
            exclui(prato);
          else{
            P_menu Menu = new P_menu();
            Menu.inicio();
          }
    }else
    {
      Console.WriteLine("Prato inexistente :(");
      Console.WriteLine(" ");
      Console.WriteLine("pressione enter para prosseguir.");       
      Console.ReadKey();
      P_menu menu = new P_menu();
      menu.inicio();
    }
  }

  public void altera(P_prato prato){
    int contador = 0;
    string resposta;

    Console.WriteLine(" ");
    Console.WriteLine("Deseja alterar o nome do prato?");
    Console.WriteLine("Digite 'sim' ou 'não'");
    resposta = Console.ReadLine();
    
    if(resposta=="sim"){
      Console.WriteLine(" ");
      Console.WriteLine("Digite o novo nome:");
      prato.novonome = Console.ReadLine();
    }
    else{
      contador++;
    }

    Console.WriteLine(" ");
    Console.WriteLine("Deseja alterar o preço do prato?");
    Console.WriteLine("Digite 'sim' ou 'não'");
    resposta = Console.ReadLine();
      
    if(resposta=="sim"){
      Console.WriteLine(" ");
      Console.WriteLine("Digite o novo preço:");
      prato.preco = Convert.ToDouble(Console.ReadLine());
    }
    else{
      contador++;
    } 
    
    if(contador !=2){
      P_bd banco = new P_bd();
      bool retorno = banco.EditPrato(prato);
      
      if(retorno == true){
        Console.WriteLine("");
        Console.WriteLine("Alteração realizada com sucesso");
      }
      else{
        Console.WriteLine("");
        Console.WriteLine("Problemas para alterar");
      }
    }

    Console.WriteLine("");
    Console.WriteLine("pressione enter para prosseguir :)");       
    Console.ReadKey();
    P_menu Menu = new P_menu();
    Menu.inicio();
  }

  public void exclui(P_prato prato){
    Console.WriteLine(" ");
    Console.WriteLine("Deseja Excluir o prato?");
    Console.WriteLine("digite 'sim' ou 'não'");
    string resposta = Console.ReadLine();

    if(resposta == "sim"){
      P_bd banco = new P_bd();
      bool retorno = banco.Exclui_prato(prato);
      if(retorno == true){
      Console.WriteLine(" ");
      Console.WriteLine("Exclusão realizada com sucesso!");}
      else{
      Console.WriteLine(" ");
      Console.WriteLine("Problemas para Excluir o prato...");
      }
    }

    Console.WriteLine(" ");
    Console.WriteLine("pressione enter para prosseguir :)");       

    Console.ReadKey();
    P_menu Menu = new P_menu();
    Menu.inicio();
  }
}
