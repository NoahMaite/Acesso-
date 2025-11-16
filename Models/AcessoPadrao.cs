using System;


public class AcessoPadrao : Acesso {
public AcessoPadrao(string produto, string empresa, int metodo, string login, string senha)
: base(produto, empresa, metodo, login, senha) {}


public override void MostrarAcesso() {
Console.WriteLine($"[PADRÃO] Produto: {Produto}, Empresa: {Empresa}, Login: {Login}, Data: {Data}");
}
}
