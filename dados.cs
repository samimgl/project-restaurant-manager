using System;
class dados{
  public void carrega()
  {
    string[] nome = {"Hamburguer","Pizza","Salada","Estrogonofe","Espaguete"};
    string novonome = "";
    double[] preco = {20.90, 35.90, 26.90, 29.90, 23.90};
    string[] descricao = {"Pão, hambúrguer de carne, queijo, alface, cebola, tomate, maionese.","Molho de tomate, mussarela, calabresa fatiada, cebola e orégano.","legumes cozidos, couve flor, brócolis, cenoura.","Estrogonofe de frango com arroz e batata palha.","spaghetti à bolonhesa."};
    
    for(int i=0; i < 5; i++)
    {
      novonome = nome[i];
      P_prato prato = new P_prato(nome[i], novonome, preco[i],descricao[i]);
      P_bd.Pratos.Add(prato);
    }
    
    P_login login = new P_login("chef", "12345");
    P_bd.loginS.Add(login);
  }
}
