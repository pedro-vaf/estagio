namespace EstagioAutomind.Usuario;

public class ListarUsuario {
	/* Metódo para listar usuários */
	public static void listar(List<CadastroUsuario> usuario) {
		
		try {
			/* Verificar se tem dados na lista */
			if (usuario.Count == 0)
				throw new Exception("A lista está vazia, a seção cadastrado será acessada.");
			
			Console.WriteLine("\n*** Lista de usuáro ***");
			foreach (var u in usuario) {
				Console.WriteLine();
				Console.WriteLine($"Nome: {u.Nome}");
				Console.WriteLine($"Email: {u.Email}");
				Console.WriteLine($"Idade: {u.Idade}");
			}
			
		}
		catch (Exception e) {
			/* Capturamos o erro caso a lista esteja vazia */
			Console.WriteLine($"Erro: {e.Message}");
			
			/* Em caso de lista vazia, seção de cadastro é chamada automaticamente */
			CadastroUsuario.Cadastro(usuario);
		}
		
	}
}
