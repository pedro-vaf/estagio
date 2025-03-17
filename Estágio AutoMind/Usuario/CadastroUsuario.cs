namespace EstagioAutomind.Usuario;

public class CadastroUsuario
{
	/* Classe de cadastro de usuário com parâmetros e encapsulamento
		get para retorno e visualização e set para modificação */
	public string Nome {get; set;}
	public string Email {get; set;}
	public int  Idade {get; set;}
	
	/* Construtores com argumentos */
	public CadastroUsuario(string nome, string email, int idade) {
		Nome = nome;
		Email = email;
		Idade = idade;
	}
	
	public static void Cadastro(List<CadastroUsuario> usuario) {
		int temp = -1; /* variável para controle do loop doWhile */
		do {
			Console.WriteLine("\n*** Cadastro Usuário ***");
			Console.Write("Nome: ");
			string nome = Console.ReadLine();
			Console.Write("Email: ");
			string email = Console.ReadLine();
			
			/* Tratamento de entrada para idade */
			int idade;
			bool idadeValida = false; /* booleano para validação */
			while (!idadeValida) {
				Console.Write("Idade: ");
				string IdadeEntrada = Console.ReadLine();
				
				if (int.TryParse(IdadeEntrada, out idade) && idade > 0) {
					idade = int.Parse(IdadeEntrada);
					idadeValida = true;
					
					/* returna instância de cadastro */
					CadastroUsuario DadoUsuario = new CadastroUsuario(nome, email, idade);
					usuario.Add(DadoUsuario);
				} else {
					Console.WriteLine("Por favor, insira uma idade válida (um número inteiro positivo).");
				}
			}
			
			/* Tratamento para continuação de cadastro */ 
			bool continuar = false;
			
			while (!continuar) {
				Console.Write("\nDeseja cadastrar mais um usuário? [1 sim | 0 não]: ");
				string continuarCadastro = Console.ReadLine();
				
				if (int.TryParse(continuarCadastro, out temp)) {
					/* se for um inteiro, validar a opção */
					if (temp == 0 || temp == 1) {
						temp = int.Parse(continuarCadastro);
						continuar = true;
					} else { Console.WriteLine("Opção inválida. Por favor, insira '1' para sim ou '0' para não.");}
				} else { Console.WriteLine("Só é permitido inteiro"); }
			}
		} while (temp == 1);
	}
}
