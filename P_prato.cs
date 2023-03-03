using System;
using System.Collections.Generic;

class P_prato {
    public string nome { get; set; }
    public string novonome { get; set;}
    public double preco { get; set; }
    public string descricao {get; set; }

    public P_prato(string nome, string novonome, double preco, string descricao)
    {
      this.nome = nome;
      this.novonome = novonome;
      this.preco = preco;
      this.descricao = descricao;
    }
}
