using System;


public class AcessoAdministrador : Acesso {
public string RegistroSistema { get; set; }


public AcessoAdministrador(string produto, string empresa, int metodo, string login, string senha, string registro)
: base(produto, empresa, metodo, login, senha) {
RegistroSistema = registro;
}


public override void MostrarAcesso() {
Console.WriteLine($"[ADMIN] Produto: {Produto}, Empresa: {Empresa}, Login: {Login}, Registro: {RegistroSistema}, Data: {Data}");
}
}
