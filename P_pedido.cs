using System;
using System.Collections.Generic;

class P_pedido{
  public string prato { get; set; }
  public string cliente { get; set; }
  public double qtde { get; set; }
  public double precoTotal  { get; set; }
  public double troco   { get; set; }
  public double valorPago   { get; set; }

  public P_pedido(string prato, string cliente, double qtde, double precoTotal, double troco, double valorPago)
  {
    this.prato = prato;
    this.cliente = cliente;
    this.qtde = qtde;
    this.precoTotal = precoTotal;
    this.troco = troco;
    this.valorPago = valorPago;
  }
}
