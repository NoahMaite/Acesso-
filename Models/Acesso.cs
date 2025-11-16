using System;


public abstract class Acesso {
public string Produto { get; set; }
public string Empresa { get; set; }
public int MetodoAutenticacao { get; set; }
public string Login { get; set; }
public string Senha { get; set; }
public string Data { get; set; }


protected Acesso(string produto, string empresa, int metodoAutenticacao, string login, string senha) {
Produto = produto;
Empresa = empresa;
MetodoAutenticacao = metodoAutenticacao;
Login = login;
Senha = senha;
Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
}


public abstract void MostrarAcesso();
}
