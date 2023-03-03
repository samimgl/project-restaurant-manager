using System;
using System.Collections.Generic;

class P_anotaPedido{
  public void anotaPedido(){
    string prato = " ";
    string cliente = " ";
    double qtde = 0;
    double vP = 0;
    double tr = 0, pT = 0;

    Console.Clear();
    
    Console.WriteLine("Digite o nome do cliente: ");
    cliente = Console.ReadLine();
    Console.WriteLine("Digite o nome do prato pedido:");
    prato = Console.ReadLine();    
    Console.WriteLine("Digite a quantidade de porções pedida:");
    qtde = Convert.ToDouble(Console.ReadLine());

    P_pedido novoPedido = new P_pedido(prato, cliente, qtde, vP, tr, pT);
    P_bd BD = new P_bd();
    BD.anotaPedido(novoPedido);
    P_prato nomeprato = BD.Busca_prato(prato);

    if(nomeprato.nome != " "){
      Console.WriteLine("");
      Console.WriteLine("PREÇO DO PRATO: " + nomeprato.preco);
      calcula(prato, cliente, qtde, vP, tr, pT);
      Console.WriteLine(" ");
      Console.WriteLine("pressione enter para prosseguir :)");       
      Console.ReadKey();
      P_menu menu = new P_menu();
      menu.inicio();
    }else
    {
      Console.WriteLine("");
      Console.WriteLine("Prato inexistente.");
      Console.WriteLine(" ");

      Console.WriteLine("Pressione enter para prosseguir :)");
      Console.ReadKey();
      P_menu menu = new P_menu();
      menu.inicio();
    }
  } 

  public void calcula(string prato, string cliente, double qtde, double precoTotal, double valorPago, double troco){
    P_bd BD = new P_bd();
    P_prato nomeprato = BD.Busca_prato(prato);
    P_pedido pedido = BD.Busca_pedido(cliente);

    pedido.precoTotal = (nomeprato.preco * pedido.qtde);

    Console.WriteLine(" ");
    Console.WriteLine("O VALOR TOTAL DO PEDIDO: {0}", pedido.precoTotal);
    Console.WriteLine(" ");
    Console.WriteLine("Precisará de troco?");
    Console.WriteLine("Digite 'sim' ou 'não'");
    string resposta = Console.ReadLine();
    Console.WriteLine(" ");

    if(resposta == "sim"){
      Console.WriteLine("Digite o valor que o cliente pagará:");
      pedido.valorPago = Convert.ToDouble(Console.ReadLine());
      pedido.troco = (pedido.valorPago - pedido.precoTotal);
      
      Console.WriteLine("TROCO = " + Math.Round(pedido.troco,2).ToString());
      Console.WriteLine("");

      Console.WriteLine("Deseja emitir a nota fiscal do pedido?");
      Console.WriteLine("digite 'sim' ou 'não'");

      string resposta2 = Console.ReadLine();
    
      if (resposta2 == "sim"){
        Console.Clear();
        Console.WriteLine("NOME DO CLIENTE: "+ pedido.cliente);
        Console.WriteLine(" ");
        Console.WriteLine("PRATO PEDIDO: "  + nomeprato.nome);
        Console.WriteLine(" ");
        Console.WriteLine("VALOR DO PRATO: "  + nomeprato.preco);
        Console.WriteLine(" ");
        Console.WriteLine("QUANTIDADE PEDIDA: " + pedido.qtde);
        Console.WriteLine(" ");
        Console.WriteLine("VALOR TOTAL DO PEDIDO: " + pedido.precoTotal);
        Console.WriteLine("");
        Console.WriteLine("VALOR PAGO PELO CLIENTE: " + pedido.valorPago);
        Console.WriteLine("");
        Console.WriteLine("TROCO: " + Math.Round(pedido.troco,2));
      }
      else{
        Console.WriteLine("");
        Console.WriteLine("Pressione enter para confirmar.");
        Console.ReadKey();
      }
    }
    else{
      Console.WriteLine("Preço total a pagar: " + pedido.precoTotal);
      Console.WriteLine("");

      Console.WriteLine("Deseja emitir a nota do pedido?");
      Console.WriteLine("digite 'sim' ou 'não'");
      string resposta2 = Console.ReadLine();
    
      if (resposta2 == "sim"){
        Console.Clear();
        Console.WriteLine("NOME DO CLIENTE: " + pedido.cliente);
        Console.WriteLine(" ");
        Console.WriteLine("PRATO PEDIDO: "  + nomeprato.nome);
        Console.WriteLine(" ");
        Console.WriteLine("VALOR DO PRATO: "  + nomeprato.preco);
        Console.WriteLine(" ");
        Console.WriteLine("QUANTIDADE PEDIDA: " + pedido.qtde);
        Console.WriteLine(" ");
        Console.WriteLine("VALOR TOTAL DO PEDIDO: " +   pedido.precoTotal);
        Console.WriteLine("");
        Console.WriteLine("VALOR PAGO PELO CLIENTE: " + pedido.precoTotal);
        Console.WriteLine("");
        Console.WriteLine("NÃO PRECISOU DE TROCO.");
      }
      else{
        Console.WriteLine("");
        Console.WriteLine("Pressione enter para confirmar.");
        Console.ReadKey();
      }
    }
  }
}
