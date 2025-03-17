namespace EstagioAutomind.Usuario;

public class Menu {
	public static int menu() {
		int opcaoMenu = -1;
		bool menuValidador = false; /* booleano para validação */
		
		while (!menuValidador) {
			Console.WriteLine("\n*** Menu ***");
			Console.WriteLine("0 - sair");
			Console.WriteLine("1 - Cadastrar usuário");
			Console.WriteLine("2 - Listar usuários");
			Console.WriteLine("3 - Buscar usuário");
			Console.Write("Insira alguma opção para continuar: ");
			string entrada = Console.ReadLine();
				
			/* verifica se a entrada pode ser convertida para inteiro */
			if (int.TryParse(entrada, out opcaoMenu)) {
				
				/* se for um inteiro, validar a opção */
				if (opcaoMenu >= 0 && opcaoMenu <= 3) {
					menuValidador = true;
					opcaoMenu = int.Parse(entrada);
				} else {  Console.WriteLine("Opção inválida. Por favor, insira um número entre 0 e 3."); }
				
			} else { Console.WriteLine("Entrada inválida. Por favor, digite um número válido."); }
		}
		return opcaoMenu;
	}
}
