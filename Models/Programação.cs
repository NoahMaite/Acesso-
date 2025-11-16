using System;


Console.Write("Empresa: ");
string emp = Console.ReadLine();


Console.Write("Método de autenticação (número): ");
int m = int.Parse(Console.ReadLine());


Console.Write("Login: ");
string login = Console.ReadLine();


Console.Write("Senha: ");
string senha = Console.ReadLine();


Console.Write("É administrador? (s/n): ");
char adm = char.Parse(Console.ReadLine().ToLower());


if (adm == 's') {
Console.Write("Registro do sistema: ");
string reg = Console.ReadLine();
controle.Inserir(new AcessoAdministrador(prod, emp, m, login, senha, reg));
} else {
controle.Inserir(new AcessoPadrao(prod, emp, m, login, senha));
}
break;


case 2:
controle.Listar();
break;


case 3:
Console.Write("Produto para buscar: ");
controle.Buscar(Console.ReadLine());
break;


case 4:
Console.Write("Produto para remover: ");
controle.Remover(Console.ReadLine());
break;


case 0:
Console.WriteLine("Saindo...");
break;


default:
Console.WriteLine("Opção inválida!\n");
break;
}
} while (opcao != 0);
}
}
