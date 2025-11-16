using System;
}


public void Listar() {
if (acessos.Count == 0) {
Console.WriteLine("Nenhum acesso cadastrado.\n");
return;
}


foreach (var a in acessos) a.MostrarAcesso();
Console.WriteLine();
}


public void Buscar(string produto) {
var resultado = acessos.Find(a => a.Produto.ToLower() == produto.ToLower());


if (resultado == null) {
Console.WriteLine("Acesso não encontrado.\n");
return;
}


resultado.MostrarAcesso();
Console.WriteLine();
}


public void Remover(string produto) {
var a = acessos.Find(x => x.Produto.ToLower() == produto.ToLower());
if (a == null) {
Console.WriteLine("Acesso não encontrado.\n");
return;
}


acessos.Remove(a);
SalvarLog();
Console.WriteLine("Acesso removido com sucesso!\n");
}


private void SalvarLog() {
using (StreamWriter sw = new StreamWriter(logPath)) {
foreach (var a in acessos) {
sw.WriteLine($"{a.GetType().Name};{a.Produto};{a.Empresa};{a.MetodoAutenticacao};{a.Login};{a.Senha};{a.Data};" +
(a is AcessoAdministrador admin ? admin.RegistroSistema : ""));
}
}
}


private void CarregarLog() {
if (!File.Exists(logPath)) return;


string[] linhas = File.ReadAllLines(logPath);


foreach (var linha in linhas) {
string[] p = linha.Split(';');
string tipo = p[0];


if (tipo == nameof(AcessoPadrao)) {
acessos.Add(new AcessoPadrao(p[1], p[2], int.Parse(p[3]), p[4], p[5]));
}
else if (tipo == nameof(AcessoAdministrador)) {
acessos.Add(new AcessoAdministrador(p[1], p[2], int.Parse(p[3]), p[4], p[5], p[7]));
}
}
}
}
