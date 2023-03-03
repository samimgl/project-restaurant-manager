using System;
using System.Collections.Generic;

class P_login{
    public string usuario { get; set; }
    public string senha { get; set; }
    
    public P_login(string usuario, string senha)
    {
      this.usuario = usuario;
      this.senha = senha;
    }
}
