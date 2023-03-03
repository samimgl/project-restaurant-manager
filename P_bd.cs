using System;
using System.Collections.Generic;

class P_bd{
  public static List<P_prato> Pratos = new List<P_prato>();
  public static List<P_pedido> Pedidos = new List<P_pedido>();
  public static List<P_login> loginS = new List<P_login>();

  public void listarPratos(){
    Console.Clear();
    Console.WriteLine("CARDÁPIO: ");
    foreach (P_prato p in Pratos)
    {
      Console.WriteLine("");
      Console.WriteLine("Nome: " + p.nome + " | Preço: " + p.preco + " | Descrição: " + p.descricao);
    }
    Console.WriteLine(" ");
    Console.WriteLine("pressione enter para prosseguir :)");       
    Console.ReadKey();
    P_menu menu = new P_menu();
    menu.inicio();
  }

  public bool anotaPedido(P_pedido pedido)
  {
    bool retorno = true;
      Pedidos.Add(pedido);
    return retorno;
  }

  public bool Cad_prato(P_prato prato)
  {
    bool retorno = true;
    Pratos.Add(prato);
    return retorno;
  }

  public P_pedido Busca_pedido(string cliente)
  {
    P_pedido retorno = new P_pedido(" "," ",0,0,0,0);
    int indice = -1;
    for(int i = 0; i < Pedidos.Count; i++)
    { 
      if(Pedidos[i].cliente == cliente)
      {
        indice = i;
        break;
      }    
    }

    if(indice != -1){
      retorno.prato = Pedidos[indice].prato;
      retorno.cliente = Pedidos[indice].cliente;
      retorno.qtde = Pedidos[indice].qtde;
      retorno.precoTotal = Pedidos[indice].precoTotal;
      retorno.troco = Pedidos[indice].troco;
      retorno.valorPago = Pedidos[indice].valorPago;
    }
    return retorno;
  }

  public P_prato Busca_prato(string nome)
    {
      P_prato retorno = new P_prato(" "," ",0," ");
      int indice = -1;
      for(int i = 0; i < Pratos.Count; i++)
      { 
        if(Pratos[i].nome == nome)
        {
          indice = i;
          break;
        }    
      }

      if(indice != -1){
        retorno.nome = Pratos[indice].nome;
        retorno.novonome = Pratos[indice].novonome;
        retorno.preco = Pratos[indice].preco;
        retorno.descricao =  Pratos[indice].descricao;
      }
    return retorno;
  }

  public bool EditPrato(P_prato prato)
  {
    bool retorno = false;
    int indice = -1;
    for(int i =0; i < Pratos.Count; i++)
    { 
      if(Pratos[i].nome == prato.nome)
      {
        indice = i;
        retorno = true;
        break;
      }
    }

    if(retorno == true){
      Pratos[indice].nome = prato.novonome;
      Pratos[indice].novonome = Pratos[indice].nome;
      Pratos[indice].preco = prato.preco;
    }
    return retorno; 
  }

  public bool Exclui_prato( P_prato prato)
  {
    bool retorno = false;
    int indice = -1;
    for(int i =0; i < Pratos.Count; i++)
    { 
      if(Pratos[i].nome == prato.nome)
      {
        indice = i;
        retorno = true;
        break;
      }    
    }
    if(retorno == true)
        Pratos.RemoveAt(indice);
    return retorno;
  }

  public bool verifica_login(P_login loginusuario)
  {   
    bool retorno = false;
    
    if (loginS[0].usuario == loginusuario.usuario && loginS[0].senha == loginusuario.senha)
    {
     retorno = true;
    }
    return retorno;
  }
     
  public bool altera_senha(string senha)
  {
    loginS[0].senha = senha;
    return true;
  }    
}
