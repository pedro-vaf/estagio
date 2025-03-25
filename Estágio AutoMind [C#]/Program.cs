using EstagioAutomind.Usuario;

namespace EstagioAutomind;

class Program
{
	static void Main(string[] args) {
		
		/* Lista encadeada para armazenar os usuários cadastrados */
		List<CadastroUsuario> usuario = new List<CadastroUsuario>();
		
		/* Retorno da classe menu para acessar as fucionalidades */
		int opcao; /* variável para controle do loop doWhile */
		do {
			opcao = Menu.menu();
			
			switch (opcao) {
				case 0:
					Console.WriteLine("Encerrando programa...");
					break;
				
				case 1:
					CadastroUsuario.Cadastro(usuario);
					break;
				
				case 2:
					ListarUsuario.listar(usuario);
					break;
				
				case 3:
					BuscarUsuario.buscar(usuario);
					break;
				
			}
		} while (opcao != 0);
		
	}
}
