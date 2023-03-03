using System;
class Program {
  public static void Main (string[] args) { 
    dados carga = new dados();
    carga.carrega();
   
    P_gerenciaLogin login = new P_gerenciaLogin();
    login.verifica_login();
  }
}
